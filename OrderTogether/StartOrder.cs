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
    public partial class StartOrder : UserControl
    {
        string[] shop_Name; //for隨機使用
        List<string> listMenuName = new List<string>();
        List<int> listMenuPrice = new List<int>();
        int loginUserId=0;
        int orderMenuId = 0;
        bool flagUId = false;
        int existNum = 0;
        int existId = 0;

        public StartOrder()
        {
            InitializeComponent();
            InsertDatabases(); //載入資料庫
            Get_ShopName();
            Randomshop(); //隨機餐廳
            //cBox_shopName.SelectedIndex = 0;
            ListView();

        }

        private void cBox_shopName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewRefresh();
            Get_Menu();
            ListView();
        }


        //隨機餐廳 (by date random 每天隨機三家)
        void Randomshop()
        {
            int ti = int.Parse(DateTime.Now.ToString("MMddyyyy"));
            Random r = new Random(ti);
            int shopRandom1;
            int shopRandom2;
            int shopRandom3;
            int shopRandom4;
            bool b = true;
            while (b)
            {
                shopRandom1 = r.Next(0, shop_Name.Length - 1);
                shopRandom2 = r.Next(0, shop_Name.Length - 1);
                shopRandom3 = r.Next(0, shop_Name.Length - 1);
                shopRandom4 = r.Next(0, shop_Name.Length - 1);
                while (shopRandom1 != shopRandom2 && shopRandom2 != shopRandom3 && shopRandom1 != shopRandom3 && shopRandom1 != shopRandom4 && shopRandom2 != shopRandom4 && shopRandom3 != shopRandom4) //隨機不重複
                {
                    //Console.WriteLine("{0},{1},{2}", shopRandom1, shopRandom2, shopRandom3); //確認隨機使用
                    cBox_shopName.Items.Add(shop_Name[shopRandom1]);
                    cBox_shopName.Items.Add(shop_Name[shopRandom2]);
                    cBox_shopName.Items.Add(shop_Name[shopRandom3]);
                    cBox_shopName.Items.Add(shop_Name[shopRandom4]);
                    b = false;
                    break;
                }
            }

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
        /// 取得資料庫對應店家菜單
        /// </summary>
        public void Get_Menu()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM Shop_Menu INNER JOIN Shop_Name ON Shop_Name.id = Shop_Menu.shop_id_FK WHERE shop_name = @shopName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shopName", cBox_shopName.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            string img_dir = @"image";
            string image_name = "";
            //int i = 0;
            while (reader.Read())
            {
                listMenuName.Add((string)reader["shop_menu"]);
                listMenuPrice.Add((int)reader["menu_price"]);
                image_name = (string)reader["menu_photo"];
                imageList1.Images.Add(Image.FromFile(img_dir + "\\" + image_name));
            }
            reader.Close();
            con.Close();
        }

        void ListView()
        {
            lView_Menu.Clear();
            lView_Menu.View = View.List;
            imageList1.ImageSize = new Size(100, 100);
            lView_Menu.LargeImageList = imageList1;
            lView_Menu.SmallImageList = imageList1;
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("新細明體", 14, FontStyle.Regular);
                item.Text = listMenuName[i];
                lView_Menu.Items.Add(item);

            }
        }

        void ListViewRefresh()
        {
            listMenuName.Clear();
            listMenuPrice.Clear();
            imageList1.Images.Clear();
        }




        private void lView_Menu_MouseClick_1(object sender, MouseEventArgs e)
        {
            //show menu + price
            lbl_MenuSelect.Text = lView_Menu.SelectedItems[0].Text;
            lbl_MenuSelectPrice.Text = listMenuPrice[listMenuName.IndexOf(lView_Menu.SelectedItems[0].Text)] + "元";
            Console.WriteLine(listMenuName.IndexOf(lView_Menu.SelectedItems[0].Text));
            Console.WriteLine(listMenuPrice[listMenuName.IndexOf(lView_Menu.SelectedItems[0].Text)]);
        }

        private void btn_randomShopMenu_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            cBox_shopName.SelectedIndex = r.Next(0, cBox_shopName.Items.Count);
            int menuRandom = r.Next(0, imageList1.Images.Count);
            lbl_MenuSelect.Text = listMenuName[menuRandom];
            lbl_MenuSelectPrice.Text = listMenuPrice[menuRandom] + "元";
        }

        private void btn_addToReview_Click(object sender, EventArgs e)
        {
            GetUserId();
            GetMenuId();
            CompareIdRepeat();
            if (flagUId == true) //若重複update值
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "UPDATE OrderList SET num=@num WHERE id=@id";
                existNum += (int)num_count.Value;
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@num", existNum);
                cmd.Parameters.AddWithValue("@id", existId);
                cmd.ExecuteReader(); //寫入commend
                con.Close();
            }
            else
            { //若未重複則新增
                InputOrderListToSQL();
            }
        }

        /// <summary>
        /// 讀取點餐資訊寫入資料庫
        /// </summary>
        public void GetUserId()
        {
            //get User ID
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string UserSQL = "SELECT Users.id FROM Users WHERE Users.user_name = @loginUserName";
            SqlCommand cmd = new SqlCommand(UserSQL, con);
            cmd.Parameters.AddWithValue("@loginUserName", SystemOwner.loginUserName);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                loginUserId = (int)reader["id"];
            }
            Console.WriteLine(loginUserId);
            reader.Close();
            con.Close();
        }
        public void GetMenuId()
        {
            //Get Menu ID
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string MenuSQL = "SELECT Shop_Menu.id FROM Shop_Menu WHERE Shop_Menu.shop_menu = @MemuName";
            SqlCommand cmd1 = new SqlCommand(MenuSQL, con);
            cmd1.Parameters.AddWithValue("@MemuName", lbl_MenuSelect.Text);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
               
                orderMenuId = (int)reader["id"];
            }
            Console.WriteLine(orderMenuId);
            reader.Close();
            con.Close();
        }
        public void InputOrderListToSQL()
        {
            //讀取頁面資料寫入
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "insert into OrderList values(@loginUserName,@orderMenuId,@count)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@loginUserName", loginUserId);
            cmd.Parameters.AddWithValue("@orderMenuId", orderMenuId);
            cmd.Parameters.AddWithValue("@count", num_count.Value);
            cmd.ExecuteReader(); //寫入commend
            con.Close();
        }

        public void CompareIdRepeat()
        {
            //重複資料確認
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select id, user_id_FK, shop_menu_id_FK, num from OrderList";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                flagUId = false;
                //若重複立Flag
                if (loginUserId == (int)reader["user_id_FK"] && orderMenuId == (int)reader["shop_menu_id_FK"])
                {
                    flagUId = true;
                    existId = (int)reader["id"];
                    existNum = (int)reader["num"];
                    break;
                }
                else
                {
                    
                }
                
            }
            Console.WriteLine(flagUId);
            con.Close();
        }

        
    }
}
