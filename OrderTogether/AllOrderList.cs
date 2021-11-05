using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderTogether
{
    public partial class AllOrderList : UserControl
    {
        List<string> Shop訂單資訊 = new List<string>();
        List<string> Class訂單資訊 = new List<string>();
        List<string> ClassUsername = new List<string>();

        public AllOrderList()
        {
            InitializeComponent();
            InsertDatabases();
            GetShop();
            AlllistRefresh();
            lbox3_shopName.SelectedIndex = 0;
        }

        private void lbox3_shopName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlllistRefresh();
        }

        private void btn3_OutputByshop_Click(object sender, EventArgs e)
        {
            GetOutputForm(OuputOrderByShop());
        }
        private void btn3_OrderListSelf_Click(object sender, EventArgs e)
        {
            GetOutputForm(OuputOrderByself());
        }

        //==========================================================================================================
        //載入資料庫data
        //==========================================================================================================
        SqlConnectionStringBuilder scsb;
        public string myDBConnectionString = "";
        /// <summary>
        /// 資料庫連線資訊載入
        /// </summary>
        /// 
        public void InsertDatabases()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Bento_orders"; //db名稱
            scsb.IntegratedSecurity = true; //windows驗證
            //myDBConnectionString = scsb.ToString();
            myDBConnectionString = @"Data Source=iiifullstack.database.windows.net;Initial Catalog=Lunch_Orders;User ID=iiifullstack;Password=Fullstack!";
        }

        public void GetShop()
        {
            lbox3_shopName.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //讀取頁面資料寫入
            string strSQL = "SELECT DISTINCT Shop_Name.shop_name FROM OrderList INNER JOIN Users ON Users.id = OrderList.user_id_FK INNER JOIN Shop_Menu ON Shop_Menu.id = OrderList.shop_menu_id_FK INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            SqlDataReader reader = sqlAdp.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                lbox3_shopName.Items.Add(reader["shop_name"]);
            }
            con.Close();

        }
        public string GetShopPhone()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //讀取頁面資料寫入
            string strSQL = "select shop_phone from Shop_Name where shop_name = @shopName";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@shopName", lbox3_shopName.Text);
            SqlDataReader reader = sqlAdp.SelectCommand.ExecuteReader();
            string shopPhone = "";
            while (reader.Read())
            {
                shopPhone = (string)reader["shop_phone"];
            }
            con.Close();
            lbl3_ShopPhone.Text = shopPhone;
            return shopPhone;
        }
        public void GetOrderListByShop()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT OrderList.id, Shop_Menu.shop_menu as 餐點, OrderList.num as 數量, Shop_Menu.menu_price as 單價 FROM OrderList INNER JOIN Users ON Users.id = OrderList.user_id_FK INNER JOIN Shop_Menu ON Shop_Menu.id = OrderList.shop_menu_id_FK INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id WHERE Shop_Name.shop_name = @shopName;";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@shopName", lbox3_shopName.Text);
            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV3_OrderList.DataSource = dT;
            Hidden();
            con.Close();
            CalTotalCount(1); //cell index 
            dT.Columns.Add("價格", typeof(int));  //計算count * price
            int count = 0;
            for (int i = 0; i < dGV3_OrderList.Rows.Count; i++)
            {
                count += (int)dGV3_OrderList.Rows[i].Cells[2].Value * (int)dGV3_OrderList.Rows[i].Cells[3].Value;
                dGV3_OrderList.Rows[i].Cells[4].Value = (int)dGV3_OrderList.Rows[i].Cells[2].Value * (int)dGV3_OrderList.Rows[i].Cells[3].Value;
                lbl3_TotlaPrice.Text = count.ToString();
            }

        }

        public void CalTotalCount(int n) //by shop total count
        {
            for (int i = 0; i <= dGV3_OrderList.Rows.Count - 1; i++)
            {
                for (int j = dGV3_OrderList.Rows.Count - 1; j >= 0; j--)
                {
                    if (dGV3_OrderList.Rows[i].Cells[n].Value.ToString() == dGV3_OrderList.Rows[j].Cells[n].Value.ToString() && i != j)
                    {
                        dGV3_OrderList.Rows[i].Cells[n + 1].Value = (int)dGV3_OrderList.Rows[i].Cells[n + 1].Value + (int)dGV3_OrderList.Rows[j].Cells[n + 1].Value;
                        dGV3_OrderList.Rows.RemoveAt(j);
                    }
                }
            }
        }


        public void Hidden()
        {
            dGV3_OrderList.Columns[0].Visible = false; //隱藏不需要被看見id欄
            dGV3_OrderList.RowHeadersVisible = false; //隱藏醜陋空白欄
            dGV3_OrderList.AllowUserToAddRows = false; //隱藏醜陋空白列
            dGV3_OrderList.Columns["數量"].ReadOnly = true;
            dGV3_OrderList.Columns["餐點"].ReadOnly = true;
            dGV3_OrderList.Columns["單價"].ReadOnly = true;
        }

        public void AlllistRefresh()
        {

            GetShopPhone();
            GetOrderListByShop();
        }

        //==========================================================================================================
        //匯出資料
        //==========================================================================================================
        /// <summary>
        /// 存檔方法
        /// </summary>
        /// <param name="input"></param>
        void GetOutputForm(List<string> input)
        {
            //自訂預設儲存名稱
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //string str檔案路徑 = @"C:\Users\DIDI\Documents\C#程式設計\WinFormTest"; //儲存檔案路徑
            Random myRnd = new Random();//提供預設檔名 時間秒&亂數
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum + @"訂購檔.txt"; //HH 12H  hh 24h.  //保險上@斜線
            string str完整檔案路徑 = dir + @"\" + str檔名;

            //檔案儲存對話框製作供使用者選擇
            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = dir; //預設初始化路徑
            sfd.FileName = str檔名; //預設初始化檔名
            sfd.Filter = "Text File|*.txt";//可接受副檔名描述 |or隔開 *任意 .txt可接受副檔名形式

            System.Windows.Forms.DialogResult R = sfd.ShowDialog();//使用者回應  

            if (R == DialogResult.OK)
            {//確定
                str完整檔案路徑 = sfd.FileName;
            }//取消
            else
            {
                return;
            }

            List<string> list訂單資訊 = input;
            //儲存
            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8); //UTF8 萬國碼 可同時顯示各種語言 (手機也許亂碼) //big5 舊式編碼會衝突
            MessageBox.Show("存檔成功");

        }

        /// <summary>
        /// 存檔內文Byshop方法
        /// </summary>
        /// <returns></returns>
        public List<string> OuputOrderByShop()
        {
            //列印訂購單
            Shop訂單資訊.Add("********************* 便當店訂購單 ***************************");
            Shop訂單資訊.Add("-------------------------------------------------------------");
            Shop訂單資訊.Add(DateTime.Now.ToString());
            Shop訂單資訊.Add("-------------------------------------------------------------");
            Shop訂單資訊.Add("-------------------------------------------------------------");
            Shop訂單資訊.Add("<<店家訂購品項>>");
            Shop訂單資訊.Add("                                                     ");


            foreach (var item in lbox3_shopName.Items)
            {
                string phone = GetShopPhone();
                Shop訂單資訊.Add((string)item + "\n 連絡電話:" + phone);
                Shop訂單資訊.Add("                                                             ");
                Shop訂單資訊.Add("品項\t\t數量\t單價\t總價");
                Shop訂單資訊.Add("-------------------------------------------------------------");
                GetOrderListByShop((string)item); //取得By餐廳方法
                Shop訂單資訊.Add("                                                             ");
                Shop訂單資訊.Add("                                                             ");
                Shop訂單資訊.Add("-------------------------------------------------------------");
                Shop訂單資訊.Add("                                                             ");
            }


            Shop訂單資訊.Add("-------------------------------------------------------------");
            Shop訂單資訊.Add("-------------------------------------------------------------");
            //列印訂購單
            //格式設定結束
            return Shop訂單資訊;
        }


        /// <summary>
        /// 輸出記事本Byshop
        /// </summary>
        /// <param name="input"></param>
        public void GetOrderListByShop(string input) //多載for輸出表單
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQLByshop = "SELECT Shop_Menu.shop_menu as 餐點, OrderList.num as 數量, Shop_Menu.menu_price as 單價 FROM OrderList INNER JOIN Users ON Users.id = OrderList.user_id_FK INNER JOIN Shop_Menu ON Shop_Menu.id = OrderList.shop_menu_id_FK INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id WHERE Shop_Name.shop_name = @shopName;";
            SqlDataAdapter sqlAdpByshop = new SqlDataAdapter(strSQLByshop, con);
            sqlAdpByshop.SelectCommand.Parameters.AddWithValue("@shopName", input);
            DataTable dT = new DataTable();
            sqlAdpByshop.Fill(dT);
            dGV3_OrderList.DataSource = dT;
            con.Close();
            CalTotalCount(0);
            dT.Columns.Add("價格", typeof(int));  //計算count * price
            int totalPriceByShop = 0;
            for (int i = 0; i < dGV3_OrderList.Rows.Count; i++)
            {
                dGV3_OrderList.Rows[i].Cells[3].Value = (int)dGV3_OrderList.Rows[i].Cells[2].Value * (int)dGV3_OrderList.Rows[i].Cells[1].Value;
                totalPriceByShop += (int)dGV3_OrderList.Rows[i].Cells[3].Value;
            }
            dGV3_OrderList.Text = string.Format("{0}", totalPriceByShop);

            string csv = "";
            foreach (DataGridViewRow row in dGV3_OrderList.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString() + "\t";
                }
                csv += "\n";
            }
            Shop訂單資訊.Add(csv);
            //Console.WriteLine(csv); //test
            //                        //Console.WriteLine(dGV_OrderListByshop.Rows.Count); //test
            Shop訂單資訊.Add("-----------------------------------------------------");
            Shop訂單資訊.Add("\t\t\tTotal\t" + totalPriceByShop.ToString() + "元");
        }



        /// <summary>
        /// 存檔內文Byclass方法
        /// </summary>
        /// <returns></returns>
        public List<string> OuputOrderByself()
        {
            GetUsers();
            //列印訂購單

            Class訂單資訊.Add("********************* 便當店訂購單 ***************************");
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add(DateTime.Now.ToString());
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("<<訂購品項>>");
            Class訂單資訊.Add("                                                     ");

            foreach (var item in ClassUsername)
            {
                Console.WriteLine(item);
                Class訂單資訊.Add((string)item);
                Class訂單資訊.Add("-------------------------------------------------------------");
                Class訂單資訊.Add("餐廳\t\t品項\t\t數量\t單價");
                Class訂單資訊.Add("-------------------------------------------------------------");
                GetOrderListByClass((string)item);
                Class訂單資訊.Add("                                                             ");
                Class訂單資訊.Add("                                                             ");
                Class訂單資訊.Add("-------------------------------------------------------------");
                Class訂單資訊.Add("                                                             ");
            }

            foreach (var item in ClassUsername)
            {

            }
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("                                                     ");
            //列印訂購單
            //格式設定結束
            return Class訂單資訊;

        }


        /// <summary>
        /// 輸出記事本ByClass
        /// </summary>
        /// <param name="input"></param>
        public void GetOrderListByClass(string input) //多載for輸出表單
        {
            InsertDatabases();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQLByClass = "SELECT Shop_Name.shop_name as 餐廳, Shop_Menu.shop_menu as 餐點, OrderList.num as 數量, Shop_Menu.menu_price as 單價 FROM OrderList INNER JOIN Users ON Users.id = OrderList.user_id_FK INNER JOIN Shop_Menu ON Shop_Menu.id = OrderList.shop_menu_id_FK INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id WHERE Users.user_name = @username;";
            SqlDataAdapter sqlAdpByClass = new SqlDataAdapter(strSQLByClass, con);
            sqlAdpByClass.SelectCommand.Parameters.AddWithValue("@username", input);
            DataTable dT = new DataTable();
            sqlAdpByClass.Fill(dT);
            dGV3_OrderList.DataSource = dT;
            con.Close();

            int totalPriceByClass = 0;

            for (int i = 0; i < dGV3_OrderList.Rows.Count; i++)
            {
                totalPriceByClass += (int)dGV3_OrderList.Rows[i].Cells[2].Value * (int)dGV3_OrderList.Rows[i].Cells[3].Value; //計算總價
            }

            string csv = "";
            foreach (DataGridViewRow row in dGV3_OrderList.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString() + "\t";

                }
                csv += "\n";
            }
            Class訂單資訊.Add(csv);
            //Console.WriteLine(csv); //test
            Class訂單資訊.Add("-----------------------------------------------------");
            Class訂單資訊.Add("\t\t\t\tTotal\t" + totalPriceByClass.ToString() + "元");
            //Console.WriteLine(totalPriceByClass);
            //Console.WriteLine(dGV_OrderListByshop.Rows.Count); //test
        }

        public void GetUsers()
        {
            InsertDatabases();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQLByClass = "SELECT DISTINCT Users.user_name FROM OrderList INNER JOIN Users ON Users.id = OrderList.user_id_FK INNER JOIN Shop_Menu ON Shop_Menu.id = OrderList.shop_menu_id_FK INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id WHERE Class_Name.classes=@loginUserClass";
            SqlCommand cmd = new SqlCommand(strSQLByClass, con);
            cmd.Parameters.AddWithValue("@loginUserClass", SystemOwner.loginUserClass);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ClassUsername.Add((string)reader["user_name"]);
            }
            reader.Close();
            con.Close();
        }


    }
}
