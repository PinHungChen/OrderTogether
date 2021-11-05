
namespace OrderTogether
{
    partial class userMaintain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cBox4_UserLevel = new System.Windows.Forms.ComboBox();
            this.dGV5_userLevel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV5_userLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // cBox4_UserLevel
            // 
            this.cBox4_UserLevel.Font = new System.Drawing.Font("新細明體", 13F);
            this.cBox4_UserLevel.FormattingEnabled = true;
            this.cBox4_UserLevel.Location = new System.Drawing.Point(173, 23);
            this.cBox4_UserLevel.Name = "cBox4_UserLevel";
            this.cBox4_UserLevel.Size = new System.Drawing.Size(121, 34);
            this.cBox4_UserLevel.TabIndex = 0;
            this.cBox4_UserLevel.SelectedIndexChanged += new System.EventHandler(this.cBox4_UserLevel_SelectedIndexChanged);
            // 
            // dGV5_userLevel
            // 
            this.dGV5_userLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV5_userLevel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV5_userLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV5_userLevel.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGV5_userLevel.Location = new System.Drawing.Point(45, 75);
            this.dGV5_userLevel.Name = "dGV5_userLevel";
            this.dGV5_userLevel.RowHeadersWidth = 62;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dGV5_userLevel.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dGV5_userLevel.RowTemplate.Height = 31;
            this.dGV5_userLevel.Size = new System.Drawing.Size(1123, 341);
            this.dGV5_userLevel.TabIndex = 1;
            this.dGV5_userLevel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV5_userLevel_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "權限選擇:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(322, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "(一般生/值日生/管理員)";
            // 
            // userMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV5_userLevel);
            this.Controls.Add(this.cBox4_UserLevel);
            this.Name = "userMaintain";
            this.Size = new System.Drawing.Size(1197, 506);
            this.Load += new System.EventHandler(this.userMaintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV5_userLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox4_UserLevel;
        private System.Windows.Forms.DataGridView dGV5_userLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
