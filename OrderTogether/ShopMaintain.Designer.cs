
namespace OrderTogether
{
    partial class ShopMaintain
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
            this.btn4_addMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuUpdate1 = new OrderTogether.MenuUpdate();
            this.shopUpdate1 = new OrderTogether.ShopUpdate();
            this.SuspendLayout();
            // 
            // btn4_addMenu
            // 
            this.btn4_addMenu.Font = new System.Drawing.Font("新細明體", 13F);
            this.btn4_addMenu.Location = new System.Drawing.Point(179, 17);
            this.btn4_addMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn4_addMenu.Name = "btn4_addMenu";
            this.btn4_addMenu.Size = new System.Drawing.Size(127, 27);
            this.btn4_addMenu.TabIndex = 6;
            this.btn4_addMenu.Text = "新增菜單";
            this.btn4_addMenu.UseVisualStyleBackColor = true;
            this.btn4_addMenu.Click += new System.EventHandler(this.btn4_addMenu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 13F);
            this.button1.Location = new System.Drawing.Point(32, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "新增餐廳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuUpdate1
            // 
            this.menuUpdate1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuUpdate1.Location = new System.Drawing.Point(-1, 63);
            this.menuUpdate1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.menuUpdate1.Name = "menuUpdate1";
            this.menuUpdate1.Size = new System.Drawing.Size(797, 272);
            this.menuUpdate1.TabIndex = 7;
            this.menuUpdate1.Load += new System.EventHandler(this.menuUpdate1_Load);
            // 
            // shopUpdate1
            // 
            this.shopUpdate1.BackColor = System.Drawing.Color.LightSlateGray;
            this.shopUpdate1.Location = new System.Drawing.Point(-1, 63);
            this.shopUpdate1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.shopUpdate1.Name = "shopUpdate1";
            this.shopUpdate1.Size = new System.Drawing.Size(797, 272);
            this.shopUpdate1.TabIndex = 8;
            // 
            // ShopMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.menuUpdate1);
            this.Controls.Add(this.btn4_addMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shopUpdate1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShopMaintain";
            this.Size = new System.Drawing.Size(798, 337);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn4_addMenu;
        private System.Windows.Forms.Button button1;
        private MenuUpdate menuUpdate1;
        private ShopUpdate shopUpdate1;
    }
}
