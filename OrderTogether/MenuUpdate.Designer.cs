
namespace OrderTogether
{
    partial class MenuUpdate
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
            this.dGV4_MenuMaintain = new System.Windows.Forms.DataGridView();
            this.btn4_MenuUpdateConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt4_PriceUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4_MenuUpdate = new System.Windows.Forms.TextBox();
            this.btn4_UploadPic = new System.Windows.Forms.Button();
            this.btn4_MenuRemove = new System.Windows.Forms.Button();
            this.pBox4_UpdatePic = new System.Windows.Forms.PictureBox();
            this.cBox4_shopName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV4_MenuMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4_UpdatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV4_MenuMaintain
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dGV4_MenuMaintain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV4_MenuMaintain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV4_MenuMaintain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV4_MenuMaintain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV4_MenuMaintain.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV4_MenuMaintain.Location = new System.Drawing.Point(26, 73);
            this.dGV4_MenuMaintain.Name = "dGV4_MenuMaintain";
            this.dGV4_MenuMaintain.RowHeadersWidth = 62;
            this.dGV4_MenuMaintain.RowTemplate.Height = 31;
            this.dGV4_MenuMaintain.Size = new System.Drawing.Size(785, 313);
            this.dGV4_MenuMaintain.TabIndex = 2;
            this.dGV4_MenuMaintain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV4_MenuMaintain_CellValueChanged);
            // 
            // btn4_MenuUpdateConfirm
            // 
            this.btn4_MenuUpdateConfirm.Font = new System.Drawing.Font("新細明體", 13F);
            this.btn4_MenuUpdateConfirm.Location = new System.Drawing.Point(843, 267);
            this.btn4_MenuUpdateConfirm.Name = "btn4_MenuUpdateConfirm";
            this.btn4_MenuUpdateConfirm.Size = new System.Drawing.Size(330, 40);
            this.btn4_MenuUpdateConfirm.TabIndex = 71;
            this.btn4_MenuUpdateConfirm.Text = "確定新增";
            this.btn4_MenuUpdateConfirm.UseVisualStyleBackColor = true;
            this.btn4_MenuUpdateConfirm.Click += new System.EventHandler(this.btn4_MenuUpdateConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(838, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 70;
            this.label1.Text = "新增價錢:";
            // 
            // txt4_PriceUpdate
            // 
            this.txt4_PriceUpdate.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt4_PriceUpdate.Location = new System.Drawing.Point(843, 132);
            this.txt4_PriceUpdate.Name = "txt4_PriceUpdate";
            this.txt4_PriceUpdate.Size = new System.Drawing.Size(156, 39);
            this.txt4_PriceUpdate.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(838, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 26);
            this.label5.TabIndex = 68;
            this.label5.Text = "新增餐點 :";
            // 
            // txt4_MenuUpdate
            // 
            this.txt4_MenuUpdate.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt4_MenuUpdate.Location = new System.Drawing.Point(843, 47);
            this.txt4_MenuUpdate.Name = "txt4_MenuUpdate";
            this.txt4_MenuUpdate.Size = new System.Drawing.Size(156, 39);
            this.txt4_MenuUpdate.TabIndex = 67;
            // 
            // btn4_UploadPic
            // 
            this.btn4_UploadPic.Font = new System.Drawing.Font("新細明體", 13F);
            this.btn4_UploadPic.Location = new System.Drawing.Point(843, 203);
            this.btn4_UploadPic.Name = "btn4_UploadPic";
            this.btn4_UploadPic.Size = new System.Drawing.Size(330, 40);
            this.btn4_UploadPic.TabIndex = 72;
            this.btn4_UploadPic.Text = "上傳圖片";
            this.btn4_UploadPic.UseVisualStyleBackColor = true;
            this.btn4_UploadPic.Click += new System.EventHandler(this.btn4_UploadPic_Click);
            // 
            // btn4_MenuRemove
            // 
            this.btn4_MenuRemove.Font = new System.Drawing.Font("新細明體", 13F);
            this.btn4_MenuRemove.Location = new System.Drawing.Point(843, 329);
            this.btn4_MenuRemove.Name = "btn4_MenuRemove";
            this.btn4_MenuRemove.Size = new System.Drawing.Size(330, 40);
            this.btn4_MenuRemove.TabIndex = 73;
            this.btn4_MenuRemove.Text = "確定移除";
            this.btn4_MenuRemove.UseVisualStyleBackColor = true;
            this.btn4_MenuRemove.Click += new System.EventHandler(this.btn4_MenuRemove_Click);
            // 
            // pBox4_UpdatePic
            // 
            this.pBox4_UpdatePic.Location = new System.Drawing.Point(1011, 16);
            this.pBox4_UpdatePic.Name = "pBox4_UpdatePic";
            this.pBox4_UpdatePic.Size = new System.Drawing.Size(162, 155);
            this.pBox4_UpdatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox4_UpdatePic.TabIndex = 74;
            this.pBox4_UpdatePic.TabStop = false;
            // 
            // cBox4_shopName
            // 
            this.cBox4_shopName.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox4_shopName.FormattingEnabled = true;
            this.cBox4_shopName.Location = new System.Drawing.Point(155, 16);
            this.cBox4_shopName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox4_shopName.Name = "cBox4_shopName";
            this.cBox4_shopName.Size = new System.Drawing.Size(281, 34);
            this.cBox4_shopName.TabIndex = 76;
            this.cBox4_shopName.SelectedIndexChanged += new System.EventHandler(this.cBox4_shopName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 75;
            this.label2.Text = "餐廳選擇 ";
            // 
            // MenuUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.cBox4_shopName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBox4_UpdatePic);
            this.Controls.Add(this.btn4_MenuRemove);
            this.Controls.Add(this.btn4_UploadPic);
            this.Controls.Add(this.btn4_MenuUpdateConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4_PriceUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt4_MenuUpdate);
            this.Controls.Add(this.dGV4_MenuMaintain);
            this.Name = "MenuUpdate";
            this.Size = new System.Drawing.Size(1195, 408);
            ((System.ComponentModel.ISupportInitialize)(this.dGV4_MenuMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4_UpdatePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV4_MenuMaintain;
        private System.Windows.Forms.Button btn4_MenuUpdateConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt4_PriceUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4_MenuUpdate;
        private System.Windows.Forms.Button btn4_UploadPic;
        private System.Windows.Forms.Button btn4_MenuRemove;
        private System.Windows.Forms.PictureBox pBox4_UpdatePic;
        private System.Windows.Forms.ComboBox cBox4_shopName;
        private System.Windows.Forms.Label label2;
    }
}
