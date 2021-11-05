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


    public partial class Form1 : Form
    {
        //==========================================================================================================
        //連結資料庫
        //==========================================================================================================
        //==========================================================================================================
        string[] shop_Name; //for隨機使用

        //表單資料寫入使用
        public string userNameOutput, shopNameOutput, shopMenuOutput, classNameOutput, paystatus;
        public int menuPriceOutput, countOutput;
        public bool b = false;
        public const int consCount = 1;
        public List<string> Self訂單資訊 = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            


            //==========================================================================================================
            InsertDatabases(); //取得資料庫路徑
            Get_ClassName(); //取得資料庫班級
            Get_ShopName(); //取得資料庫店名
            Get_Users(); //取得資料庫使用者
            Get_Menu(); //取得資料庫菜單
            Get_MenuPrice(); //取得資料庫價格
            InputdataToOrderList(cBox_className.Text);
            Randomshop(); //餐廳隨機載入

            //載入預設值
            lbl_price.Text = "";
            lBox_orderReview.Items.Clear(); //清除預設
            cBox_className.SelectedIndex = 0; //className預設
            cBox_shopName.SelectedIndex = 0; //shopName預設
            cBox_users.SelectedIndex = 0; //users預設
            num_count.Value = 1; //數量預設
            rBtn_notPay.Checked = true; //未付款預設
            lbl_date.Text = string.Format("{0}", DateTime.Now);//時間預設
        }



        private void cBox_className_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox_users.Items.Clear();
            Get_Users(); //載入對應姓名
            cBox_users.SelectedIndex = 0;
            InputdataToOrderList(cBox_className.Text);
        }

        private void tBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBox_shopName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox_shopMenu.Items.Clear(); //清除預設
            Get_Menu();
            cBox_shopMenu.SelectedIndex = 0;
        }

        private void cBox_shopMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_MenuPrice();
        }

        private void btn_randomShopMenu_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            cBox_shopName.SelectedIndex = r.Next(0, cBox_shopName.Items.Count);
            cBox_shopMenu.SelectedIndex = r.Next(0, cBox_shopMenu.Items.Count);
        }

        private void rBtn_pay_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_pay.Checked)
            {
                b = true;
                Console.WriteLine(b);
                paystatus = " ";
            }
        }

        private void rBtn_notPay_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtn_notPay.Checked)
            {
                b = false;
                Console.WriteLine(b);
                paystatus = "未付款";
            }

        }

        private void btn_addToReview_Click(object sender, EventArgs e)
        {
            VarOuputData();
            InputOrderListToSQL(); //載入選項內菜單
            InputdataToOrderList(cBox_className.Text); //選擇對應班級顯示訂單
        }

        private void lBox_orderReview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_singleRemove_Click(object sender, EventArgs e)
        {
            DeleteFromOrderList(); //移除選擇項目
            InputdataToOrderList(cBox_className.Text); //資料表重新導入
        }

        private void btn_removeAll_Click(object sender, EventArgs e)
        {

            DeleteAllOrderList(); //移除所有項目
            InputdataToOrderList(cBox_className.Text); //資料表重新導入
        }

        private void btn_orderConfirm_Click(object sender, EventArgs e)
        {

            if (dGV_ouputList.RowCount < 1)
            {
                MessageBox.Show("請輸入餐點再送出訂單");
            }
            else
            {
                OrderConfirmForm finalListCheck = new OrderConfirmForm();
                finalListCheck.ShowDialog();
            }

        }

        /// <summary>
        /// 餐廳隨機 每日隨機三家
        /// </summary>
        void Randomshop()
        {
            int ti = int.Parse(DateTime.Now.ToString("MMddyyyy"));
            Random r = new Random(ti);
            int shopRandom1;
            int shopRandom2;
            int shopRandom3;
            bool b = true;
            while (b)
            {
                shopRandom1 = r.Next(0, shop_Name.Length - 1);
                shopRandom2 = r.Next(0, shop_Name.Length - 1);
                shopRandom3 = r.Next(0, shop_Name.Length - 1);
                while (shopRandom1 != shopRandom2 && shopRandom2 != shopRandom3 && shopRandom1 != shopRandom3) //隨機不重複
                {
                    Console.WriteLine("{0},{1},{2}", shopRandom1, shopRandom2, shopRandom3); //確認隨機使用
                    cBox_shopName.Items.Add(shop_Name[shopRandom1]);
                    cBox_shopName.Items.Add(shop_Name[shopRandom2]);
                    cBox_shopName.Items.Add(shop_Name[shopRandom3]);
                    b = false;
                    break;
                }
            }
        }

        public void VarOuputData()
        {
            countOutput = (int)num_count.Value;
            Console.WriteLine(countOutput.GetType());
        }


        //==========================================================================================================
        //載入資料庫data
        //==========================================================================================================
        SqlConnectionStringBuilder scsb;
        public string myDBConnectionString = "";

        /// <summary>
        /// 資料庫連線資訊載入
        /// </summary>
        public void InsertDatabases()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Bento_orders"; //db名稱
            scsb.IntegratedSecurity = true; //windows驗證
            //myDBConnectionString = scsb.ToString();
            myDBConnectionString = @"Data Source=iiifullstack.database.windows.net;Initial Catalog=Lunch_Orders;User ID=iiifullstack;Password=Fullstack!";
        }

        /// <summary>
        /// 取得資料庫班級
        /// </summary>
        public void Get_ClassName()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select classes from Class_Name;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cBox_className.Items.Add(reader["classes"]);
            }
            reader.Close();
            con.Close();
        }

        /// <summary>
        /// 取得資料庫店名
        /// </summary>
        public void Get_ShopName()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select shop_name from Shop_Name;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> str = new List<string>();
            while (reader.Read())
            {
                str.Add((string)reader["shop_name"]);
                shop_Name = str.ToArray();
            }
            reader.Close();
            con.Close();
        }

        /// <summary>
        /// 取得資料庫班級人名
        /// </summary>
        public void Get_Users()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT user_name, classes FROM Users INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id WHERE classes = @ClassName;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ClassName", cBox_className.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cBox_users.Items.Add(reader["user_name"]);
                //Console.WriteLine(reader["user_name"]);//test
            }
            reader.Close();
            con.Close();
        }

        /// <summary>
        /// 取得資料庫對應店家菜單
        /// </summary>
        public void Get_Menu()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT shop_menu FROM Shop_Menu INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK WHERE shop_name = @shopName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shopName", cBox_shopName.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cBox_shopMenu.Items.Add(reader["shop_menu"]);
                //Console.WriteLine(reader["shop_menu"]); //test
            }
            reader.Close();
            con.Close();
        }

        /// <summary>
        /// 取得Menu價格
        /// </summary>
        public void Get_MenuPrice()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT menu_price FROM Shop_Menu WHERE shop_menu = @shopMenu";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shopMenu", cBox_shopMenu.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                menuPriceOutput = (int)reader["menu_price"]; //取得價格int
                lbl_price.Text = string.Format("{0}", menuPriceOutput); //轉換價格string
            }
            reader.Close();
            con.Close();
        }

        //==========================================================================================================
        //輸出增刪菜單資訊至資料庫
        //==========================================================================================================

        /// <summary>
        /// 讀取點餐資訊寫入資料庫
        /// </summary>
        public void InputOrderListToSQL()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();

            //讀取頁面資料寫入
            string strSQL = "insert into OrderList_Output values(@ClassesName,@users,@shopName,@Menu,@counts,@MenuPrice,@paystatus)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ClassesName", cBox_className.Text);
            cmd.Parameters.AddWithValue("@users", cBox_users.Text);
            cmd.Parameters.AddWithValue("@shopName", cBox_shopName.Text);
            cmd.Parameters.AddWithValue("@Menu", cBox_shopMenu.Text);
            cmd.Parameters.AddWithValue("@counts", countOutput);
            cmd.Parameters.AddWithValue("@MenuPrice", menuPriceOutput);
            cmd.Parameters.AddWithValue("@paystatus", b);
            cmd.ExecuteReader(); //寫入commend
            con.Close();

            InputdataToOrderList(cBox_className.Text);
        }

        /// <summary>
        /// 所有資料表導入
        /// </summary>
        public void InputdataToOrderList()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select id, class_name,users_name,shop_name,menu,count,price,paystatus from OrderList_Output;";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV_ouputList.DataSource = dT;
            Hidden();
            con.Close();
        }

        /// <summary>
        /// 以班為單位顯示資料表資料
        /// </summary>
        /// <param name="input"></param>
        public void InputdataToOrderList(string input)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select id, class_name ,users_name as 姓名,shop_name as 餐廳,menu as 餐點,count as 數量,price as 單價,paystatus as 是否付款 from OrderList_Output where class_name = @ClassName;";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@ClassName", cBox_className.Text);
            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV_ouputList.DataSource = dT;
            Hidden();
            con.Close();
        }

        /// <summary>
        /// 移除選擇項
        /// </summary>
        public void DeleteFromOrderList()
        {
            string orderId = dGV_ouputList.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(orderId);
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "delete from OrderList_Output where id = @orderID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderID", orderId);
            cmd.ExecuteReader();
            con.Close();

        }

        /// <summary>
        /// 刪除所有選項
        /// </summary>
        public void DeleteAllOrderList()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "delete from OrderList_Output";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteReader();
            con.Close();

        }
        //==========================================================================================================
        //==========================================================================================================

        /// <summary>
        /// 隱藏不需要列表
        /// </summary>
        public void Hidden()
        {
            dGV_ouputList.Columns[0].Visible = false; //隱藏不需要被看見id欄
            dGV_ouputList.Columns[1].Visible = false; //隱藏不需要被看見class欄
            dGV_ouputList.RowHeadersVisible = false; //隱藏醜陋空白欄
            dGV_ouputList.AllowUserToAddRows = false; //隱藏醜陋空白列
        }


        public void GetOrderListBySelf(string input) //多載for輸出表單
        {

            InsertDatabases();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select id, class_name ,users_name ,shop_name ,menu ,count ,price ,paystatus as 是否付款 from OrderList_Output where class_name = @ClassName;";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@ClassName", input);
            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV_ouputList.DataSource = dT;
            Hidden();
            con.Close();

            CalTotalCountByClass();
            int totalPriceByClass = 0;
            
            for (int i = 0; i < dGV_ouputList.Rows.Count; i++)
            {

                dGV_ouputList.Rows[i].Cells[6].Value = (int)dGV_ouputList.Rows[i].Cells[5].Value * (int)dGV_ouputList.Rows[i].Cells[6].Value;
                totalPriceByClass += (int)dGV_ouputList.Rows[i].Cells[6].Value;
            }

            dGV_ouputList.Text = string.Format("{0}", totalPriceByClass); //計算總價


            string csv = "";
            foreach (DataGridViewRow row in dGV_ouputList.Rows)
            {
                for (int i = 2; i < row.Cells.Count; i++)
                {
                    csv += row.Cells[i].Value.ToString() + "\t";
                }
                
                csv += "\n";
                
            }
            Console.WriteLine(totalPriceByClass);
            Console.WriteLine(csv);
            Self訂單資訊.Add(csv);
            Console.WriteLine(csv); //test
                                    //Console.WriteLine(dGV_OrderListByshop.Rows.Count); //test
            Self訂單資訊.Add("-------------------------------------------------------------------------");
            Self訂單資訊.Add("\t\t\t\t\t\tTotal\t" + totalPriceByClass.ToString() + "元");

        }
        public void CalTotalCountByClass() //byClass total count
        {
            for (int i = 0; i <= dGV_ouputList.Rows.Count - 1; i++)
            {
                for (int j = dGV_ouputList.Rows.Count - 1; j >= 0; j--)
                {
                    if (dGV_ouputList.Rows[i].Cells[4].Value.ToString() == dGV_ouputList.Rows[j].Cells[4].Value.ToString() && i != j)
                    {
                        dGV_ouputList.Rows[i].Cells[5].Value = (int)dGV_ouputList.Rows[i].Cells[5].Value + (int)dGV_ouputList.Rows[j].Cells[5].Value;
                        dGV_ouputList.Rows.RemoveAt(j);

                    }

                }
               
            }

        }

    }
}
