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
    public partial class ShopUpdate : UserControl
    {
        public ShopUpdate()
        {
            InitializeComponent();
        }

        private void dGV4_ShopUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshMenuMaintain();

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

        public void GetShoplist()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT Shop_Name.id, Shop_Name.shop_name, Shop_Name.shop_phone FROM Shop_Name;";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV4_ShopUpdate.DataSource = dT;
            con.Close();
            Hidden();
        }
        public void Hidden()
        {
            dGV4_ShopUpdate.Columns[0].Visible = false; //隱藏不需要被看見id欄
            dGV4_ShopUpdate.RowHeadersVisible = false; //隱藏醜陋空白欄
            dGV4_ShopUpdate.AllowUserToAddRows = false; //隱藏醜陋空白列
        }

        public void RefreshMenuMaintain()
        {
            InsertDatabases();
            GetShoplist();
        }

        private void dGV4_ShopUpdate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "UPDATE Shop_Name SET shop_name=@shop_name, shop_phone=@shop_phone WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shop_name", dGV4_ShopUpdate.CurrentRow.Cells[1].Value);
            cmd.Parameters.AddWithValue("@shop_phone", dGV4_ShopUpdate.CurrentRow.Cells[2].Value);
            cmd.Parameters.AddWithValue("@id", dGV4_ShopUpdate.CurrentRow.Cells[0].Value);
            cmd.ExecuteReader();
            con.Close();
            RefreshMenuMaintain();
        }

        
        private void btn4_ShopRemove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "DELETE Shop_Name WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", dGV4_ShopUpdate.CurrentRow.Cells[0].Value);
            cmd.ExecuteReader();
            con.Close();
            RefreshMenuMaintain();
        }

        private void btn4_shopUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "INSERT INTO Shop_Name (shop_name,shop_phone) VALUES (@shop_name, @shop_phone);";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shop_name", txt4_ShopUpdate.Text);
            cmd.Parameters.AddWithValue("@shop_phone", txt4_PhoneUpdate.Text);
            cmd.ExecuteReader();
            con.Close();
            RefreshMenuMaintain();
        }
    }
}
