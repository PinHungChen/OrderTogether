using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTogether
{
    public partial class SystemOwner : Form
    {
        public static string loginUserName ="",loginUserAuthority="",loginUserClass="";
        //private void uxEvent(object sender, EventArgs e)
        //{
        //    //do something(including send message to other user controls)
        //}

        


        public SystemOwner()
        {
            
            InitializeComponent();
            ////顯示第一頁
            pnl_side.Height = btn1_StartOrder.Height;
            pnl_side.Top = btn1_StartOrder.Top;
            startOrder1.BringToFront();
            //顯示登入者
            lbl1_LoginClass.Text = loginUserClass;
            lbl1_LoginUserName.Text = loginUserName;
            lbl1_LoginAuthority.Text = $"({loginUserAuthority})";
            //分權顯示
            UserAuthorityCheck();
            //時間顯示
            lbl1_time.Text = DateTime.Now.ToString("HH:mm");
            lbl1_Date.Text = DateTime.Now.ToShortDateString();

        }

        //====================================================================
        //頁籤對應
        //====================================================================
        private void btn4_UserManager_Click(object sender, EventArgs e)
        {
            pnl_side.Height = btn4_UserManager.Height;
            pnl_side.Top = btn4_UserManager.Top;
            userMaintain1.BringToFront();
        }

        protected void btn2_MyOrder_Click(object sender, EventArgs e)
        {
            pnl_side.Height = btn2_MyOrder.Height;
            pnl_side.Top = btn2_MyOrder.Top;
            myOrderList1.BringToFront();
            myOrderList1.RefreshSelf();
        }

        private void btn3_AllOrderList_Click(object sender, EventArgs e)
        {
            pnl_side.Height = btn3_AllOrderList.Height;
            pnl_side.Top = btn3_AllOrderList.Top;
            allOrderList1.BringToFront();
            allOrderList1.AlllistRefresh();
        }

        private void btn1_StartOrder_Click(object sender, EventArgs e)
        {
            pnl_side.Height = btn1_StartOrder.Height;
            pnl_side.Top = btn1_StartOrder.Top;
            startOrder1.BringToFront();
        }

        private void SystemOwner_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btn1_StartOrder_Click_1(object sender, EventArgs e)
        {
            pnl_side.Height = btn1_StartOrder.Height;
            pnl_side.Top = btn1_StartOrder.Top;
            startOrder1.BringToFront();
        }

        private void myOrderList1_Load(object sender, EventArgs e)
        {

        }

        private void btn5_ShopMaintain_Click(object sender, EventArgs e)
        {
            pnl_side.Height = btn5_ShopMaintain.Height;
            pnl_side.Top = btn5_ShopMaintain.Top;
            shopMaintain1.BringToFront();
        }
        //====================================================================
        //====================================================================
        //確認權限
        //====================================================================
        private void UserAuthorityCheck()
        {
            switch (loginUserAuthority) {
                case "管理員":
                    btn3_AllOrderList.Visible = true;
                    btn4_UserManager.Visible = true;
                    btn5_ShopMaintain.Visible = true;
                    break;
                case "值日生":
                    btn3_AllOrderList.Visible = true;
                    btn4_UserManager.Visible = false;
                    btn5_ShopMaintain.Visible = true;
                    break;
                case "一般生":
                    btn3_AllOrderList.Visible = false;
                    btn4_UserManager.Visible = false;
                    btn5_ShopMaintain.Visible = false;
                    break;
            }
        }

    }
}
