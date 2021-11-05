
namespace OrderTogether
{
    partial class MyOrderList
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
            this.dGV2_UserOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2_Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl2_TotlaPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2_UserOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV2_UserOrder
            // 
            this.dGV2_UserOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV2_UserOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV2_UserOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV2_UserOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV2_UserOrder.Location = new System.Drawing.Point(28, 82);
            this.dGV2_UserOrder.Name = "dGV2_UserOrder";
            this.dGV2_UserOrder.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dGV2_UserOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV2_UserOrder.RowTemplate.Height = 31;
            this.dGV2_UserOrder.Size = new System.Drawing.Size(1002, 313);
            this.dGV2_UserOrder.TabIndex = 0;
            this.dGV2_UserOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV2_UserOrder_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(695, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(991, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "元";
            // 
            // btn2_Remove
            // 
            this.btn2_Remove.Font = new System.Drawing.Font("新細明體", 13F);
            this.btn2_Remove.Location = new System.Drawing.Point(28, 407);
            this.btn2_Remove.Name = "btn2_Remove";
            this.btn2_Remove.Size = new System.Drawing.Size(191, 40);
            this.btn2_Remove.TabIndex = 4;
            this.btn2_Remove.Text = "移除餐點";
            this.btn2_Remove.UseVisualStyleBackColor = true;
            this.btn2_Remove.Click += new System.EventHandler(this.btn2_Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "訂購項目";
            // 
            // lbl2_TotlaPrice
            // 
            this.lbl2_TotlaPrice.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_TotlaPrice.Location = new System.Drawing.Point(850, 414);
            this.lbl2_TotlaPrice.Name = "lbl2_TotlaPrice";
            this.lbl2_TotlaPrice.Size = new System.Drawing.Size(135, 26);
            this.lbl2_TotlaPrice.TabIndex = 6;
            this.lbl2_TotlaPrice.Text = "XXX";
            this.lbl2_TotlaPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(547, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "(*數量可直接修改)";
            // 
            // MyOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl2_TotlaPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn2_Remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV2_UserOrder);
            this.Name = "MyOrderList";
            this.Size = new System.Drawing.Size(1298, 506);
            ((System.ComponentModel.ISupportInitialize)(this.dGV2_UserOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV2_UserOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn2_Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl2_TotlaPrice;
        private System.Windows.Forms.Label label4;
    }
}
