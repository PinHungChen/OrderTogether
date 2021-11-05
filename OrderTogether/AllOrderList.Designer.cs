
namespace OrderTogether
{
    partial class AllOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn3_OutputByshop = new System.Windows.Forms.Button();
            this.dGV3_OrderList = new System.Windows.Forms.DataGridView();
            this.lbox3_shopName = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn3_OrderListSelf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl3_ShopPhone = new System.Windows.Forms.Label();
            this.lbl3_TotlaPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV3_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3_OutputByshop
            // 
            this.btn3_OutputByshop.Font = new System.Drawing.Font("新細明體", 13F);
            this.btn3_OutputByshop.Location = new System.Drawing.Point(145, 347);
            this.btn3_OutputByshop.Name = "btn3_OutputByshop";
            this.btn3_OutputByshop.Size = new System.Drawing.Size(284, 40);
            this.btn3_OutputByshop.TabIndex = 9;
            this.btn3_OutputByshop.Text = "餐廳訂單匯出";
            this.btn3_OutputByshop.UseVisualStyleBackColor = true;
            this.btn3_OutputByshop.Click += new System.EventHandler(this.btn3_OutputByshop_Click);
            // 
            // dGV3_OrderList
            // 
            this.dGV3_OrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV3_OrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV3_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV3_OrderList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV3_OrderList.Location = new System.Drawing.Point(503, 71);
            this.dGV3_OrderList.Name = "dGV3_OrderList";
            this.dGV3_OrderList.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dGV3_OrderList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV3_OrderList.RowTemplate.Height = 31;
            this.dGV3_OrderList.Size = new System.Drawing.Size(731, 370);
            this.dGV3_OrderList.TabIndex = 6;
            // 
            // lbox3_shopName
            // 
            this.lbox3_shopName.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox3_shopName.FormattingEnabled = true;
            this.lbox3_shopName.ItemHeight = 26;
            this.lbox3_shopName.Location = new System.Drawing.Point(43, 71);
            this.lbox3_shopName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox3_shopName.Name = "lbox3_shopName";
            this.lbox3_shopName.Size = new System.Drawing.Size(398, 186);
            this.lbox3_shopName.TabIndex = 18;
            this.lbox3_shopName.SelectedIndexChanged += new System.EventHandler(this.lbox3_shopName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "餐廳電話 : ";
            // 
            // btn3_OrderListSelf
            // 
            this.btn3_OrderListSelf.Font = new System.Drawing.Font("新細明體", 13F);
            this.btn3_OrderListSelf.Location = new System.Drawing.Point(145, 401);
            this.btn3_OrderListSelf.Name = "btn3_OrderListSelf";
            this.btn3_OrderListSelf.Size = new System.Drawing.Size(284, 40);
            this.btn3_OrderListSelf.TabIndex = 20;
            this.btn3_OrderListSelf.Text = "個人訂單資訊";
            this.btn3_OrderListSelf.UseVisualStyleBackColor = true;
            this.btn3_OrderListSelf.Click += new System.EventHandler(this.btn3_OrderListSelf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "所有訂單資訊";
            // 
            // lbl3_ShopPhone
            // 
            this.lbl3_ShopPhone.AutoSize = true;
            this.lbl3_ShopPhone.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            this.lbl3_ShopPhone.Location = new System.Drawing.Point(188, 290);
            this.lbl3_ShopPhone.Name = "lbl3_ShopPhone";
            this.lbl3_ShopPhone.Size = new System.Drawing.Size(142, 26);
            this.lbl3_ShopPhone.TabIndex = 24;
            this.lbl3_ShopPhone.Text = "0933333333";
            // 
            // lbl3_TotlaPrice
            // 
            this.lbl3_TotlaPrice.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl3_TotlaPrice.Location = new System.Drawing.Point(1052, 461);
            this.lbl3_TotlaPrice.Name = "lbl3_TotlaPrice";
            this.lbl3_TotlaPrice.Size = new System.Drawing.Size(135, 26);
            this.lbl3_TotlaPrice.TabIndex = 28;
            this.lbl3_TotlaPrice.Text = "XXX";
            this.lbl3_TotlaPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1193, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(897, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total Price :";
            // 
            // AllOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.lbl3_TotlaPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl3_ShopPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbox3_shopName);
            this.Controls.Add(this.dGV3_OrderList);
            this.Controls.Add(this.btn3_OutputByshop);
            this.Controls.Add(this.btn3_OrderListSelf);
            this.Name = "AllOrderList";
            this.Size = new System.Drawing.Size(1298, 506);
            ((System.ComponentModel.ISupportInitialize)(this.dGV3_OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn3_OutputByshop;
        private System.Windows.Forms.DataGridView dGV3_OrderList;
        private System.Windows.Forms.ListBox lbox3_shopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn3_OrderListSelf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl3_ShopPhone;
        private System.Windows.Forms.Label lbl3_TotlaPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
