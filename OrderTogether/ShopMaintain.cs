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
    public partial class ShopMaintain : UserControl
    {
        public ShopMaintain()
        {
            InitializeComponent();
            
        }


        private void btn4_addMenu_Click(object sender, EventArgs e)
        {
            menuUpdate1.BringToFront();
            menuUpdate1.RefreshMenuMaintain();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shopUpdate1.BringToFront();
            shopUpdate1.RefreshMenuMaintain();
            menuUpdate1.ShopRefresh();
        }

        private void menuUpdate1_Load(object sender, EventArgs e)
        {

        }
    }

}
