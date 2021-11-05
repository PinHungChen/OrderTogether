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
    public partial class MyOrderList : UserControl
    {

        

        public MyOrderList()
        {
            InitializeComponent();

            InsertDatabases();
            InputdataToOrderList();
            
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
        public void InputdataToOrderList()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT OrderList.id, Shop_Name.shop_name as 餐廳, Shop_Menu.shop_menu as 餐點, OrderList.num as 數量, Shop_Menu.menu_price as 價錢 FROM OrderList INNER JOIN Users ON Users.id = OrderList.user_id_FK INNER JOIN Shop_Menu ON Shop_Menu.id = OrderList.shop_menu_id_FK INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id WHERE Users.user_name = @loginUserName;";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@loginUserName", SystemOwner.loginUserName);
            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV2_UserOrder.DataSource = dT;
            Hidden();
            con.Close();

            int count = 0;
            for (int i = 0; i < dGV2_UserOrder.Rows.Count; i++)
            {
                count += (int)dGV2_UserOrder.Rows[i].Cells[3].Value * (int)dGV2_UserOrder.Rows[i].Cells[4].Value;
                lbl2_TotlaPrice.Text = count.ToString();
            }
            
        }

        public void Hidden()
        {
            dGV2_UserOrder.Columns[0].Visible = false; //隱藏不需要被看見id欄
            dGV2_UserOrder.RowHeadersVisible = false; //隱藏醜陋空白欄
            dGV2_UserOrder.AllowUserToAddRows = false; //隱藏醜陋空白列
            dGV2_UserOrder.Columns["數量"].ReadOnly = false;
            dGV2_UserOrder.Columns["餐廳"].ReadOnly = true;
            dGV2_UserOrder.Columns["餐點"].ReadOnly = true;
            dGV2_UserOrder.Columns["價錢"].ReadOnly = true;
        }

        /// <summary>
        /// 移除選擇項
        /// </summary>
        public void DeleteFromOrderList()
        {
            string orderId = dGV2_UserOrder.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(orderId);
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "delete from OrderList where id = @orderID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderID", orderId);
            cmd.ExecuteReader();
            con.Close();
        }

        private void btn2_Remove_Click(object sender, EventArgs e)
        { 
            DeleteFromOrderList();
            RefreshSelf();
        }

        public void RefreshSelf()
        {
            InsertDatabases();
            InputdataToOrderList();
        }


        private void dGV2_UserOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            for (int i = 0; i < dGV2_UserOrder.Rows.Count; i++)
            {
                con.Open();
                string strSQL = "UPDATE OrderList SET num=@num WHERE id=@id;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@num", dGV2_UserOrder.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@id", dGV2_UserOrder.Rows[i].Cells[0].Value);
                cmd.ExecuteReader(); //寫入commend
                con.Close();

            }
            MessageBox.Show("數量修改完成!");
            RefreshSelf();
        }


    }
}
