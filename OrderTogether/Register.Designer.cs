
namespace OrderTogether
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_RegPassword = new System.Windows.Forms.TextBox();
            this.txtBox_RegAccount = new System.Windows.Forms.TextBox();
            this.btn_RegConform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_RegName = new System.Windows.Forms.TextBox();
            this.cBox_RegClass = new System.Windows.Forms.ComboBox();
            this.lbl_RegStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F);
            this.label2.Location = new System.Drawing.Point(74, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "密碼 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_RegPassword
            // 
            this.txtBox_RegPassword.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtBox_RegPassword.Location = new System.Drawing.Point(156, 219);
            this.txtBox_RegPassword.Name = "txtBox_RegPassword";
            this.txtBox_RegPassword.PasswordChar = '*';
            this.txtBox_RegPassword.Size = new System.Drawing.Size(264, 39);
            this.txtBox_RegPassword.TabIndex = 11;
            // 
            // txtBox_RegAccount
            // 
            this.txtBox_RegAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_RegAccount.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtBox_RegAccount.Location = new System.Drawing.Point(156, 155);
            this.txtBox_RegAccount.Name = "txtBox_RegAccount";
            this.txtBox_RegAccount.Size = new System.Drawing.Size(264, 39);
            this.txtBox_RegAccount.TabIndex = 10;
            // 
            // btn_RegConform
            // 
            this.btn_RegConform.Location = new System.Drawing.Point(87, 404);
            this.btn_RegConform.Name = "btn_RegConform";
            this.btn_RegConform.Size = new System.Drawing.Size(333, 41);
            this.btn_RegConform.TabIndex = 9;
            this.btn_RegConform.Text = "註冊";
            this.btn_RegConform.UseVisualStyleBackColor = true;
            this.btn_RegConform.Click += new System.EventHandler(this.btn_RegConform_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F);
            this.label1.Location = new System.Drawing.Point(73, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "帳號 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("新細明體", 13F);
            this.label3.Location = new System.Drawing.Point(73, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "建立您的帳戶";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("新細明體", 13F);
            this.label4.Location = new System.Drawing.Point(74, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "姓名:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("新細明體", 13F);
            this.label5.Location = new System.Drawing.Point(74, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "班級:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_RegName
            // 
            this.txtBox_RegName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_RegName.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtBox_RegName.Location = new System.Drawing.Point(156, 93);
            this.txtBox_RegName.Name = "txtBox_RegName";
            this.txtBox_RegName.Size = new System.Drawing.Size(264, 39);
            this.txtBox_RegName.TabIndex = 18;
            // 
            // cBox_RegClass
            // 
            this.cBox_RegClass.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_RegClass.FormattingEnabled = true;
            this.cBox_RegClass.Location = new System.Drawing.Point(156, 289);
            this.cBox_RegClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_RegClass.Name = "cBox_RegClass";
            this.cBox_RegClass.Size = new System.Drawing.Size(264, 34);
            this.cBox_RegClass.TabIndex = 77;
            // 
            // lbl_RegStatus
            // 
            this.lbl_RegStatus.BackColor = System.Drawing.Color.White;
            this.lbl_RegStatus.Font = new System.Drawing.Font("新細明體", 13F);
            this.lbl_RegStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_RegStatus.Location = new System.Drawing.Point(87, 350);
            this.lbl_RegStatus.Name = "lbl_RegStatus";
            this.lbl_RegStatus.Size = new System.Drawing.Size(333, 37);
            this.lbl_RegStatus.TabIndex = 78;
            this.lbl_RegStatus.Text = " ";
            this.lbl_RegStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 505);
            this.Controls.Add(this.lbl_RegStatus);
            this.Controls.Add(this.cBox_RegClass);
            this.Controls.Add(this.txtBox_RegName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_RegPassword);
            this.Controls.Add(this.txtBox_RegAccount);
            this.Controls.Add(this.btn_RegConform);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_RegPassword;
        private System.Windows.Forms.TextBox txtBox_RegAccount;
        private System.Windows.Forms.Button btn_RegConform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_RegName;
        private System.Windows.Forms.ComboBox cBox_RegClass;
        private System.Windows.Forms.Label lbl_RegStatus;
    }
}