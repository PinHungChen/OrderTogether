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
    public partial class Register : Form
    {
        bool RegFlag = false;

        public Register()
        {
            InitializeComponent();
            cBox_RegClass.Items.Add("一年一班");
            cBox_RegClass.Items.Add("一年二班");
            cBox_RegClass.Items.Add("一年三班");
            cBox_RegClass.SelectedIndex = 0;
        }

        private void btn_RegConform_Click(object sender, EventArgs e)
        {
            InsertDatabases();
            CheckRegStatus(txtBox_RegAccount.Text, txtBox_RegName.Text);
            RegWrite();
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
        public void CheckRegStatus(string account, string name)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT user_Authority, user_name, user_account, user_password, classes, user_blacklist FROM Users INNER JOIN Class_Name ON Users.class_id_FK = Class_Name.id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["user_account"].ToString() == account)
                {
                    lbl_RegStatus.Text = "此帳號已被註冊, 請重新輸入";
                    account = "";
                    RegFlag = false;
                    break;
                }
                else if (reader["user_name"].ToString() == name)
                {
                    lbl_RegStatus.Text = "此姓名已被註冊, 請重新確認";
                    name = "";
                    RegFlag = false;
                    break;
                }
                else if (txtBox_RegAccount.Text == "" || txtBox_RegName.Text == "" || txtBox_RegPassword.Text == "")
                {
                    lbl_RegStatus.Text = "註冊資料不可為空白";
                    RegFlag = false;
                }
                else
                {
                    RegFlag = true;
                    Console.WriteLine("suc?");
                }
            }
            reader.Close();
            con.Close();
        }
        public void RegWrite()
        {
            if (RegFlag == true)
            {
                RegFlag = false;
                lbl_RegStatus.Text = "註冊成功, 資料寫入中";

                //data
                int regClass = 1;
                switch (cBox_RegClass.SelectedItem)
                {
                    case "一年一班":
                        regClass = 1;
                        break;
                    case "一年二班":
                        regClass = 2;
                        break;
                    case "一年三班":
                        regClass = 3;
                        break;
                }

                //寫入資料
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string RegSQL = "INSERT INTO Users (user_Authority, user_name, user_account, user_password, class_id_FK) VALUES(@user_Authority, @user_name, @user_account, @user_password, @class_id_FK)";
                SqlCommand cmdin = new SqlCommand(RegSQL, con);
                cmdin.Parameters.AddWithValue("@user_Authority", "一般生");
                cmdin.Parameters.AddWithValue("@user_name", txtBox_RegName.Text);
                cmdin.Parameters.AddWithValue("@user_account", txtBox_RegAccount.Text);
                cmdin.Parameters.AddWithValue("@user_password", MD5Helper.EncryptString(txtBox_RegPassword.Text));
                cmdin.Parameters.AddWithValue("@class_id_FK", regClass);
                cmdin.ExecuteReader();
                con.Close();
                this.Close();
                MessageBox.Show("註冊成功, 請重新登入");
            }
            else
            {

            }
        }

    }
}

