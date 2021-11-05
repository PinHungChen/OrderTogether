using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace OrderTogether
{




    public partial class userMaintain : UserControl
    {
        public userMaintain()
        {
            InitializeComponent();
            InsertDatabases();
            GetAuthority();
            cBox4_UserLevel.SelectedIndex = 0;
            GetUserList();
        }

        private void userMaintain_Load(object sender, EventArgs e)
        {

        }

        private void cBox4_UserLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserList();

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
            string strSQL = "SELECT Users.id, Users.user_authority, classes, user_name, user_blacklist FROM Users INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id WHERE user_authority = @user_authority ORDER BY classes ";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(strSQL, con);
            sqlAdp.SelectCommand.Parameters.AddWithValue("@user_authority", cBox4_UserLevel.SelectedItem);
            DataTable dT = new DataTable();
            sqlAdp.Fill(dT);
            dGV5_userLevel.DataSource = dT;
            con.Close();
            Hidden();
        }
        public void Hidden()
        {
            dGV5_userLevel.Columns[0].Visible = false; //隱藏不需要被看見id欄
            dGV5_userLevel.RowHeadersVisible = false; //隱藏醜陋空白欄
            dGV5_userLevel.AllowUserToAddRows = false; //隱藏醜陋空白列
        }


        //資料處理 - 資料更新
        private void dGV5_userLevel_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            for (int i = 0; i < dGV5_userLevel.Rows.Count; i++)
            {
                con.Open();
                string strSQL = "UPDATE Users SET Users.user_authority=@user_authority, Users.user_blacklist=@user_blacklist WHERE Users.id=@id;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@user_authority", dGV5_userLevel.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@user_blacklist", dGV5_userLevel.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@id", dGV5_userLevel.Rows[i].Cells[0].Value);
                cmd.ExecuteReader(); //寫入commend
                con.Close();
            }

            MessageBox.Show($"資料更新完成!");
            RefreshUserMaintain();
        }

        public void RefreshUserMaintain()
        {
            InsertDatabases();
            GetUserList();
        }


        //Get Authority
        public void GetAuthority()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT DISTINCT Users.user_authority FROM Users;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cBox4_UserLevel.Items.Add((string)reader["user_authority"]);
            }
            reader.Close();
            con.Close();
        }

    }


    //MD5
    public partial class MD5Helper
    {
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }
    }
    ////////////////


}
