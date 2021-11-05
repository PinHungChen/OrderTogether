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
using System.Security.Cryptography;

namespace OrderTogether
{
    public partial class LoginForm : Form
    {

        Boolean blacklistFlag = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        //login Click
        private void btn1_LoginUser_Click(object sender, EventArgs e)
        {
            InsertDatabases();
            CheckLoginStatus(txt1_LoginUser.Text, txt1_PasswordUser.Text);
            
        }

        private void btn1_LoginOnduty_Click(object sender, EventArgs e)
        {
            InsertDatabases();
            CheckLoginStatus(txt1_LoginOnduty.Text, txt1_PasswordOnduty.Text);
        }

        private void btn1_LoginSystem_Click(object sender, EventArgs e)
        {
            InsertDatabases();
            CheckLoginStatus(txt1_LoginSystem.Text, txt1_PasswordSystem.Text);
        }



        //==========================================================================================================
        //載入資料庫data
        //==========================================================================================================
        SqlConnectionStringBuilder scsb;
        public string myDBConnectionString = "";
        private bool LoginFlag = false;
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
        /// 取得資料庫帳號密碼 若資料正確登入並寫入班級 姓名 權限
        /// </summary>
        public void CheckLoginStatus(string account, string password)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT user_Authority, user_name, user_account, user_password, classes, user_blacklist FROM Users INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
             SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                if (reader["user_account"].ToString() == account && reader["user_password"].ToString() == MD5Helper.EncryptString(password))
                {
                    SystemOwner.loginUserName = (string)reader["user_name"];
                    SystemOwner.loginUserAuthority = (string)reader["user_Authority"];
                    SystemOwner.loginUserClass = (string)reader["classes"];
                    LoginFlag = true;
                    blacklistFlag = (Boolean)reader["user_blacklist"];
                    break;
                }
            }
            reader.Close();
            con.Close();
            if (LoginFlag == true)
            {
                if (blacklistFlag == false)
                {
                    LoginFlag = false;
                    MessageBox.Show("登入成功");
                    this.Hide();
                    SystemOwner myorderList = new SystemOwner();
                    myorderList.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("您已被列入黑名單, 請與系統管理員聯繫");
                }
                
            }
            else
            {
                MessageBox.Show("帳號密碼錯誤, 請重新確認");
                txt1_LoginUser.Text = "";
                txt1_PasswordUser.Text = "";
                txt1_LoginOnduty.Text = "";
                txt1_PasswordOnduty.Text = "";
                txt1_LoginSystem.Text = "";
                txt1_PasswordSystem.Text = "";
            }


        }

        private void txt1_LoginUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }

}
