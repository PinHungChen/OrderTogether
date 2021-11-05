using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace OrderTogether
{
    public partial class OrderConfirmForm : Form
    {
        List<string> Shop訂單資訊 = new List<string>();
        List<string> Class訂單資訊 = new List<string>();



        public OrderConfirmForm()
        {
            InitializeComponent();
        }

        private void OrderConfirmForm_Load(object sender, EventArgs e)
        {

            GetShop();
            GetClass();
            lbox2_shopName.SelectedIndex = 0;
            cBox2_className.SelectedIndex = 0;
            GetOrderListByShop();
            GetOrderListByClass();
            
            //=============================================================================================
            //=============================================================================================
            //=============================================================================================
            lbox2_shopName.SelectedIndex = 0;
            lbl2_dateTime.Text = string.Format("{0}", DateTime.Now);//時間預設
            GetShopPhone();
            this.ControlBox = false; //不顯示上標選項避免關閉重新加入資料重複


        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbox2_shopName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrderListByShop();
            GetShopPhone();
            
        }

        private void lbox2_orderListByshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrderListByShop();
        }

        private void btn2_OrderByShop_Click(object sender, EventArgs e)
        {
            GetOutputForm(OuputOrderByShop());
        }

        private void cBox2_className_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrderListByClass();
        }

        private void lbox2_orderListByclass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn2_orderByClass_Click(object sender, EventArgs e)
        {
            GetOutputForm(OuputOrderByClass());
        }

        private void btn2_orderBySelf_Click(object sender, EventArgs e)
        {
            GetOutputForm(OuputOrderByself());

        }



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
        /// 存檔內文Byself方法
        /// </summary>
        /// <returns></returns>
        List<string> OuputOrderByself()
        {
            //列印訂購單
            List<string> list訂單資訊 = new List<string>();
            form1.Self訂單資訊.Add("*************************** 便當訂購單 ***********************************");
            form1.Self訂單資訊.Add("-------------------------------------------------------------------------");
            form1.Self訂單資訊.Add(DateTime.Now.ToString());
            form1.Self訂單資訊.Add("-------------------------------------------------------------------------");
            form1.Self訂單資訊.Add("-------------------------------------------------------------------------");
            form1.Self訂單資訊.Add("<<個人訂購品項>>");
            form1.Self訂單資訊.Add("                                                     ");

            foreach (var item in cBox2_className.Items)
            {
                form1.Self訂單資訊.Add((string)item);
                form1.Self訂單資訊.Add("姓名\t\t餐廳\t\t品項\t\t數量\t總價\t是否付款");
                form1.Self訂單資訊.Add("-------------------------------------------------------------------------");
                form1.GetOrderListBySelf((string)item);
                form1.Self訂單資訊.Add("                                                             ");
                form1.Self訂單資訊.Add("                                                             ");
                form1.Self訂單資訊.Add("-------------------------------------------------------------------------");
                form1.Self訂單資訊.Add("                                                             ");

            }

            form1.Self訂單資訊.Add("-------------------------------------------------------------------------");
            form1.Self訂單資訊.Add("-------------------------------------------------------------------------");
            form1.Self訂單資訊.Add("                                                     ");

            //列印訂購單
            //格式設定結束
            return form1.Self訂單資訊;
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


            foreach (var item in lbox2_shopName.Items)
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


        public List<string> OuputOrderByClass()
        {
            //列印訂購單

            Class訂單資訊.Add("********************* 便當店訂購單 ***************************");
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add(DateTime.Now.ToString());
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("<<班級訂購品項>>");
            Class訂單資訊.Add("                                                     ");
            //var cN = OutputDatabase.ggg.Select(m => m._classNameOutput).Distinct().ToArray(); //輸出選擇by班級

            foreach (var item in cBox2_className.Items)
            {
                Class訂單資訊.Add((string)item);
                Class訂單資訊.Add("-------------------------------------------------------------");
                Class訂單資訊.Add("餐廳\t\t品項\t\t數量\t單價\t總價");
                Class訂單資訊.Add("-------------------------------------------------------------");
                GetOrderListByClass((string)item);
                Class訂單資訊.Add("                                                             ");
                Class訂單資訊.Add("                                                             ");
                Class訂單資訊.Add("-------------------------------------------------------------");
                Class訂單資訊.Add("                                                             ");
            }

            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("-------------------------------------------------------------");
            Class訂單資訊.Add("                                                     ");
            //列印訂購單
            //格式設定結束
            return Class訂單資訊;
        }


        //================================================================================================================================
        //================================================================================================================================
        //================================================================================================================================
        Form1 form1 = new Form1();
        public void GetShop()
        {
            form1.InsertDatabases();
            SqlConnection con = new SqlConnection(form1.myDBConnectionString);
            con.Open();
            //讀取頁面資料寫入
            string strSQL = "select DISTINCT Shop_Name.shop_name, shop_phone from OrderList_Output inner join Shop_Name on Shop_Name.shop_name = OrderList_Output.shop_name";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            SqlDataReader reader = sqlAdp.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                lbox2_shopName.Items.Add(reader["shop_name"]);
            }

            con.Close();

        }
        public string GetShopPhone()
        {
            form1.InsertDatabases();
            SqlConnection con = new SqlConnection(form1.myDBConnectionString);
            con.Open();
            //讀取頁面資料寫入
            string strSQL = "select shop_phone from Shop_Name where shop_name = @shopName";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@shopName", lbox2_shopName.Text);
            SqlDataReader reader = sqlAdp.SelectCommand.ExecuteReader();
            string shopPhone="";
            while (reader.Read())
            {
                shopPhone = (string)reader["shop_phone"];
            }
            con.Close();
            lbl2_shopPhone.Text = shopPhone;
            return shopPhone;
        }
        public void GetOrderListByShop()
        {

            SqlConnection con = new SqlConnection(form1.myDBConnectionString);
            con.Open();
            string strSQLByshop = "select menu as 餐點,count as 數量,price as 單價 from OrderList_Output where shop_name = @shopName";
            SqlDataAdapter sqlAdpByshop = new SqlDataAdapter(strSQLByshop, con);
            sqlAdpByshop.SelectCommand.Parameters.AddWithValue("@shopName", lbox2_shopName.Text);
            DataTable dT = new DataTable();
            sqlAdpByshop.Fill(dT);
            dGV_OrderListByshop.DataSource = dT;
            Hidden();
            con.Close();


            dT.Columns.Add("總價", typeof(int));  //計算count * price
            CalTotalCount();
            int totalPriceByShop = 0;
            for (int i = 0; i < dGV_OrderListByshop.Rows.Count; i++)
            {
                dGV_OrderListByshop.Rows[i].Cells[3].Value = (int)dGV_OrderListByshop.Rows[i].Cells[2].Value * (int)dGV_OrderListByshop.Rows[i].Cells[1].Value;
                totalPriceByShop += (int)dGV_OrderListByshop.Rows[i].Cells[3].Value;
            }
            lbl2_totalByShop.Text = string.Format("{0}", totalPriceByShop);
            //Console.WriteLine(dGV_OrderListByshop.Rows.Count); //test



        }




        public void CalTotalCount() //by shop total count
        {
            for (int i = 0; i <= dGV_OrderListByshop.Rows.Count - 1; i++)
            {
                for (int j = dGV_OrderListByshop.Rows.Count - 1; j >= 0; j--)
                {
                    if (dGV_OrderListByshop.Rows[i].Cells[0].Value.ToString() == dGV_OrderListByshop.Rows[j].Cells[0].Value.ToString() && i != j)
                    {
                        dGV_OrderListByshop.Rows[i].Cells[1].Value = (int)dGV_OrderListByshop.Rows[i].Cells[1].Value + (int)dGV_OrderListByshop.Rows[j].Cells[1].Value;
                        dGV_OrderListByshop.Rows.RemoveAt(j);
                    }
                }
            }
        }


        public void GetClass()
        {
            form1.InsertDatabases();
            SqlConnection con = new SqlConnection(form1.myDBConnectionString);
            con.Open();
            //讀取頁面資料寫入
            string strSQL = "select DISTINCT class_name from OrderList_Output inner join Class_Name on Class_Name.classes = OrderList_Output.class_name";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            SqlDataReader reader = sqlAdp.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                cBox2_className.Items.Add(reader["class_name"]);
                //Console.WriteLine(reader["class_name"]); //test
            }
            con.Close();
        }
        public void GetOrderListByClass()
        {
            form1.InsertDatabases();
            SqlConnection con = new SqlConnection(form1.myDBConnectionString);
            con.Open();
            string strSQLByClass = "select shop_name as 餐廳,menu as 餐點,count 數量,price as 單價 from OrderList_Output where class_name = @ClassName;";
            SqlDataAdapter sqlAdpByClass = new SqlDataAdapter(strSQLByClass, con);
            sqlAdpByClass.SelectCommand.Parameters.AddWithValue("@ClassName", cBox2_className.Text);
            DataTable dT = new DataTable();
            sqlAdpByClass.Fill(dT);
            dGV_OrderListByClass.DataSource = dT;
            con.Close();
            Hidden();

            dT.Columns.Add("總價", typeof(int)); //計算count * price
            CalTotalCountByClass();
            int totalPriceByClass = 0;

            for (int i = 0; i < dGV_OrderListByClass.Rows.Count; i++)
            {
                dGV_OrderListByClass.Rows[i].Cells[4].Value = (int)dGV_OrderListByClass.Rows[i].Cells[3].Value * (int)dGV_OrderListByClass.Rows[i].Cells[2].Value;
                totalPriceByClass += (int)dGV_OrderListByClass.Rows[i].Cells[4].Value; //計算總價

            }
            lbl2_totalByClass.Text = string.Format("{0}", totalPriceByClass); //計算總價
            Console.WriteLine(totalPriceByClass); //test
        }

        public void CalTotalCountByClass() //byClass total count
        {
            for (int i = 0; i <= dGV_OrderListByClass.Rows.Count - 1; i++)
            {
                for (int j = dGV_OrderListByClass.Rows.Count - 1; j >= 0; j--)
                {
                    if (dGV_OrderListByClass.Rows[i].Cells[1].Value.ToString() == dGV_OrderListByClass.Rows[j].Cells[1].Value.ToString() && i != j)
                    {
                        dGV_OrderListByClass.Rows[i].Cells[2].Value = (int)dGV_OrderListByClass.Rows[i].Cells[2].Value + (int)dGV_OrderListByClass.Rows[j].Cells[2].Value;
                        dGV_OrderListByClass.Rows.RemoveAt(j);
                    }
                }
            }
            //Console.WriteLine(dGV_OrderListByClass.Rows[0].Cells[1].Value.ToString()); //test
        }




        public void Hidden()
        {
            dGV_OrderListByshop.RowHeadersVisible = false; //隱藏醜陋空白欄
            dGV_OrderListByshop.AllowUserToAddRows = false; //隱藏醜陋空白列
            dGV_OrderListByClass.RowHeadersVisible = false;
            dGV_OrderListByClass.AllowUserToAddRows = false;
        }


        //========================================================================================================
        /// <summary>
        /// 輸出記事本ByClass
        /// </summary>
        /// <param name="input"></param>
        public void GetOrderListByClass(string input) //多載for輸出表單
        {

            form1.InsertDatabases();
            SqlConnection con = new SqlConnection(form1.myDBConnectionString);
            con.Open();
            string strSQLByClass = "select shop_name as 餐廳,menu as 餐點,count 數量,price as 單價 from OrderList_Output where class_name = @ClassName;";
            SqlDataAdapter sqlAdpByClass = new SqlDataAdapter(strSQLByClass, con);
            sqlAdpByClass.SelectCommand.Parameters.AddWithValue("@ClassName", input);
            DataTable dT = new DataTable();
            sqlAdpByClass.Fill(dT);
            dGV_OrderListByClass.DataSource = dT;
            con.Close();
            Hidden();

            dT.Columns.Add("總價", typeof(int)); //計算count * price
            CalTotalCountByClass();
            int totalPriceByClass = 0;

            for (int i = 0; i < dGV_OrderListByClass.Rows.Count; i++)
            {
                dGV_OrderListByClass.Rows[i].Cells[4].Value = (int)dGV_OrderListByClass.Rows[i].Cells[3].Value * (int)dGV_OrderListByClass.Rows[i].Cells[2].Value;
                totalPriceByClass += (int)dGV_OrderListByClass.Rows[i].Cells[4].Value; //計算總價

            }

            lbl2_totalByClass.Text = string.Format("{0}", totalPriceByClass); //計算總價

            string csv = "";
            foreach (DataGridViewRow row in dGV_OrderListByClass.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString() + "\t";

                }
                csv += "\n";
            }
            Class訂單資訊.Add(csv);
            Console.WriteLine(csv); //test
            Class訂單資訊.Add("-----------------------------------------------------");
            Class訂單資訊.Add("\t\t\t\t\t\tTotal\t" + totalPriceByClass.ToString() + "元");
            Console.WriteLine(totalPriceByClass);
            //Console.WriteLine(dGV_OrderListByshop.Rows.Count); //test
        }
        /// <summary>
        /// 輸出記事本Byshop
        /// </summary>
        /// <param name="input"></param>
        public void GetOrderListByShop(string input) //多載for輸出表單
        {

            SqlConnection con = new SqlConnection(form1.myDBConnectionString);
            con.Open();
            string strSQLByshop = "select menu as 餐點,count as 數量,price as 單價 from OrderList_Output where shop_name = @shopName";
            SqlDataAdapter sqlAdpByshop = new SqlDataAdapter(strSQLByshop, con);
            sqlAdpByshop.SelectCommand.Parameters.AddWithValue("@shopName", input);
            DataTable dT = new DataTable();
            sqlAdpByshop.Fill(dT);
            dGV_OrderListByshop.DataSource = dT;
            Hidden();
            con.Close();


            dT.Columns.Add("總價", typeof(int));  //計算count * price
            CalTotalCount();
            int totalPriceByShop = 0;
            for (int i = 0; i < dGV_OrderListByshop.Rows.Count; i++)
            {
                dGV_OrderListByshop.Rows[i].Cells[3].Value = (int)dGV_OrderListByshop.Rows[i].Cells[2].Value * (int)dGV_OrderListByshop.Rows[i].Cells[1].Value;
                totalPriceByShop += (int)dGV_OrderListByshop.Rows[i].Cells[3].Value;
            }
            lbl2_totalByShop.Text = string.Format("{0}", totalPriceByShop);

            string csv = "";
            foreach (DataGridViewRow row in dGV_OrderListByshop.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString() + "\t";

                }
                csv += "\n";
            }
            Shop訂單資訊.Add(csv);
            Console.WriteLine(csv); //test
                                    //Console.WriteLine(dGV_OrderListByshop.Rows.Count); //test
            Shop訂單資訊.Add("-----------------------------------------------------");
            Shop訂單資訊.Add("\t\tTotal\t" + totalPriceByShop.ToString() + "元");
            Console.WriteLine(totalPriceByShop);
        }



    }
}
