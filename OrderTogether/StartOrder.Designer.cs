
namespace OrderTogether
{
    partial class StartOrder
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_MenuSelect = new System.Windows.Forms.Label();
            this.btn_addToReview = new System.Windows.Forms.Button();
            this.btn_randomShopMenu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.num_count = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_shopName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lView_Menu = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_MenuSelectPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MenuSelect
            // 
            this.lbl_MenuSelect.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_MenuSelect.Location = new System.Drawing.Point(867, 249);
            this.lbl_MenuSelect.Name = "lbl_MenuSelect";
            this.lbl_MenuSelect.Size = new System.Drawing.Size(238, 42);
            this.lbl_MenuSelect.TabIndex = 53;
            this.lbl_MenuSelect.Text = " ";
            this.lbl_MenuSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_addToReview
            // 
            this.btn_addToReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_addToReview.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_addToReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToReview.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addToReview.Location = new System.Drawing.Point(930, 396);
            this.btn_addToReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addToReview.Name = "btn_addToReview";
            this.btn_addToReview.Size = new System.Drawing.Size(288, 64);
            this.btn_addToReview.TabIndex = 51;
            this.btn_addToReview.Text = "加入我的訂單 >>";
            this.btn_addToReview.UseVisualStyleBackColor = false;
            this.btn_addToReview.Click += new System.EventHandler(this.btn_addToReview_Click);
            // 
            // btn_randomShopMenu
            // 
            this.btn_randomShopMenu.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_randomShopMenu.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_randomShopMenu.Location = new System.Drawing.Point(930, 79);
            this.btn_randomShopMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_randomShopMenu.Name = "btn_randomShopMenu";
            this.btn_randomShopMenu.Size = new System.Drawing.Size(288, 64);
            this.btn_randomShopMenu.TabIndex = 50;
            this.btn_randomShopMenu.Text = "給我隨便來一種 !";
            this.btn_randomShopMenu.UseVisualStyleBackColor = true;
            this.btn_randomShopMenu.Click += new System.EventHandler(this.btn_randomShopMenu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(998, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 32);
            this.label10.TabIndex = 49;
            this.label10.Text = "選擇障礙?";
            // 
            // num_count
            // 
            this.num_count.BackColor = System.Drawing.Color.White;
            this.num_count.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num_count.Location = new System.Drawing.Point(1181, 316);
            this.num_count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(69, 39);
            this.num_count.TabIndex = 48;
            this.num_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(1104, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "數量:";
            // 
            // cBox_shopName
            // 
            this.cBox_shopName.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_shopName.FormattingEnabled = true;
            this.cBox_shopName.Location = new System.Drawing.Point(171, 27);
            this.cBox_shopName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_shopName.Name = "cBox_shopName";
            this.cBox_shopName.Size = new System.Drawing.Size(281, 34);
            this.cBox_shopName.TabIndex = 58;
            this.cBox_shopName.Text = "-- 請選擇餐廳 --";
            this.cBox_shopName.SelectedIndexChanged += new System.EventHandler(this.cBox_shopName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(41, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 57;
            this.label5.Text = "餐廳選擇 ";
            // 
            // lView_Menu
            // 
            this.lView_Menu.BackColor = System.Drawing.Color.LightSlateGray;
            this.lView_Menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lView_Menu.GridLines = true;
            this.lView_Menu.HideSelection = false;
            this.lView_Menu.Location = new System.Drawing.Point(46, 105);
            this.lView_Menu.MultiSelect = false;
            this.lView_Menu.Name = "lView_Menu";
            this.lView_Menu.Size = new System.Drawing.Size(757, 369);
            this.lView_Menu.TabIndex = 59;
            this.lView_Menu.TileSize = new System.Drawing.Size(50, 50);
            this.lView_Menu.UseCompatibleStateImageBehavior = false;
            this.lView_Menu.View = System.Windows.Forms.View.SmallIcon;
            this.lView_Menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lView_Menu_MouseClick_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(867, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 60;
            this.label1.Text = "您選擇的是 : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(836, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 470);
            this.panel1.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(476, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "(每日隨機四家餐廳)";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(80, 80);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(873, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 2);
            this.panel2.TabIndex = 62;
            // 
            // lbl_MenuSelectPrice
            // 
            this.lbl_MenuSelectPrice.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_MenuSelectPrice.Location = new System.Drawing.Point(1111, 249);
            this.lbl_MenuSelectPrice.Name = "lbl_MenuSelectPrice";
            this.lbl_MenuSelectPrice.Size = new System.Drawing.Size(139, 42);
            this.lbl_MenuSelectPrice.TabIndex = 63;
            this.lbl_MenuSelectPrice.Text = " ";
            this.lbl_MenuSelectPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.lbl_MenuSelectPrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lView_Menu);
            this.Controls.Add(this.lbl_MenuSelect);
            this.Controls.Add(this.num_count);
            this.Controls.Add(this.cBox_shopName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_addToReview);
            this.Controls.Add(this.btn_randomShopMenu);
            this.Controls.Add(this.label10);
            this.Name = "StartOrder";
            this.Size = new System.Drawing.Size(1298, 506);
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_MenuSelect;
        private System.Windows.Forms.Button btn_addToReview;
        private System.Windows.Forms.Button btn_randomShopMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBox_shopName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lView_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_MenuSelectPrice;
    }
}
