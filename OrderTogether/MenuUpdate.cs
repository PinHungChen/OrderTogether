using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace OrderTogether
{

    public partial class MenuUpdate : UserControl
    {
        int ShopId = 0;
        string newPicAddress = "";
        string[] newPicName;

        public MenuUpdate()
        {
            InitializeComponent();
            InsertDatabases();
            Get_ShopName();
            cBox4_shopName.SelectedIndex = 0;
        }

        private void btn4_UploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg;, *.gif; *.bmp;) |*.jpg; *.jpeg;, *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                newPicAddress = open.FileName;
                pBox4_UpdatePic.Image = new Bitmap(open.FileName);
                newPicName = newPicAddress.Split(new char[1] { '\\' });
                Console.WriteLine(newPicName.Length);
                Console.WriteLine(newPicName[newPicName.Length - 1]);
            }
            else
            {

            }

        }
        private void cBox4_shopName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMenuMaintain();
            Console.WriteLine(cBox4_shopName.SelectedItem);
        }

        private void btn4_MenuUpdateConfirm_Click(object sender, EventArgs e)
        {
            //資料表更新
            MenuListUpdate();
            //檔案傳至資料夾
            File.Copy(newPicAddress, Path.Combine(@"image\", Path.GetFileName(newPicAddress)), true);
            MessageBox.Show("檔案上傳成功");
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

        public void GetUserList()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT Shop_Menu.id, Shop_Menu.shop_menu, Shop_Menu.menu_price, Shop_Menu.menu_photo FROM Shop_Name INNER JOIN Shop_Menu ON Shop_Name.id = Shop_Menu.shop_id_FK WHERE Shop_Name.shop_name = @shop_name";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@shop_name", cBox4_shopName.SelectedItem) ;

            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV4_MenuMaintain.DataSource = dT;
            con.Close();
            Hidden();
        }
        public void Hidden()
        {
            dGV4_MenuMaintain.Columns[0].Visible = false; //隱藏不需要被看見id欄
            dGV4_MenuMaintain.RowHeadersVisible = false; //隱藏醜陋空白欄
            dGV4_MenuMaintain.AllowUserToAddRows = false; //隱藏醜陋空白列
        }

        public void RefreshMenuMaintain()
        {
            InsertDatabases();
            GetUserList();
        }


        public void MenuListUpdate()
        {
            Get_ShopId();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "INSERT INTO Shop_Menu (shop_menu,menu_price,shop_id_FK,menu_photo) VALUES (@shop_menu, @menu_price, @shop_id ,@menu_photo);";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shop_menu", txt4_MenuUpdate.Text);
            cmd.Parameters.AddWithValue("@menu_price", txt4_PriceUpdate.Text);
            cmd.Parameters.AddWithValue("@shop_id", ShopId);
            cmd.Parameters.AddWithValue("@menu_photo", newPicName[newPicName.Length - 1]);
            cmd.ExecuteReader();
            con.Close();
            RefreshMenuMaintain();
        }

        private void dGV4_MenuMaintain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "Update Shop_Menu SET shop_menu=@shop_menu, menu_price=@menu_price, menu_photo=@menu_photo WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shop_menu", dGV4_MenuMaintain.CurrentRow.Cells[1].Value);
            cmd.Parameters.AddWithValue("@menu_price", dGV4_MenuMaintain.CurrentRow.Cells[2].Value);
            cmd.Parameters.AddWithValue("@menu_photo", dGV4_MenuMaintain.CurrentRow.Cells[3].Value);
            cmd.Parameters.AddWithValue("@id", dGV4_MenuMaintain.CurrentRow.Cells[0].Value);
            cmd.ExecuteReader();
            con.Close();
            RefreshMenuMaintain();

        }

        private void btn4_MenuRemove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "DELETE Shop_Menu WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", dGV4_MenuMaintain.CurrentRow.Cells[0].Value);
            cmd.ExecuteReader();
            con.Close();
            RefreshMenuMaintain();
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
                cBox4_shopName.Items.Add((string)reader["shop_name"]); 
            }
            reader.Close();
            con.Close();
        }

        /// <summary>
        /// 取得店Id
        /// </summary>
        public void Get_ShopId()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select Shop_Name.id from Shop_Name WHERE shop_name=@shop_name;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shop_name", cBox4_shopName.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ShopId = (int)reader["id"];
            }
            reader.Close();
            con.Close();

        }
        public void ShopRefresh()
        {
            cBox4_shopName.Items.Clear();
            Get_ShopName();
            cBox4_shopName.SelectedIndex = 0;
        }
    }
}
