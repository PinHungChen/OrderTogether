
namespace OrderTogether
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn1_LoginUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1_PasswordUser = new System.Windows.Forms.TextBox();
            this.txt1_LoginUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1_PasswordOnduty = new System.Windows.Forms.TextBox();
            this.txt1_LoginOnduty = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn1_LoginOnduty = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt1_PasswordSystem = new System.Windows.Forms.TextBox();
            this.txt1_LoginSystem = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn1_LoginSystem = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F);
            this.label1.Location = new System.Drawing.Point(80, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1_LoginUser
            // 
            this.btn1_LoginUser.Location = new System.Drawing.Point(94, 381);
            this.btn1_LoginUser.Name = "btn1_LoginUser";
            this.btn1_LoginUser.Size = new System.Drawing.Size(333, 41);
            this.btn1_LoginUser.TabIndex = 2;
            this.btn1_LoginUser.Text = "登入";
            this.btn1_LoginUser.UseVisualStyleBackColor = true;
            this.btn1_LoginUser.Click += new System.EventHandler(this.btn1_LoginUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 13F);
            this.tabControl1.Location = new System.Drawing.Point(-6, -2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 607);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt1_PasswordUser);
            this.tabPage1.Controls.Add(this.txt1_LoginUser);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btn_Register);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn1_LoginUser);
            this.tabPage1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tabPage1.Size = new System.Drawing.Size(536, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "學生登入";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F);
            this.label2.Location = new System.Drawing.Point(81, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "密碼 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1_PasswordUser
            // 
            this.txt1_PasswordUser.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt1_PasswordUser.Location = new System.Drawing.Point(163, 275);
            this.txt1_PasswordUser.Name = "txt1_PasswordUser";
            this.txt1_PasswordUser.PasswordChar = '*';
            this.txt1_PasswordUser.Size = new System.Drawing.Size(264, 39);
            this.txt1_PasswordUser.TabIndex = 6;
            // 
            // txt1_LoginUser
            // 
            this.txt1_LoginUser.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt1_LoginUser.Location = new System.Drawing.Point(163, 218);
            this.txt1_LoginUser.Name = "txt1_LoginUser";
            this.txt1_LoginUser.Size = new System.Drawing.Size(264, 39);
            this.txt1_LoginUser.TabIndex = 5;
            this.txt1_LoginUser.TextChanged += new System.EventHandler(this.txt1_LoginUser_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(94, 446);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(333, 41);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "註冊";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt1_PasswordOnduty);
            this.tabPage2.Controls.Add(this.txt1_LoginOnduty);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btn1_LoginOnduty);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 13F);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "值日生";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("新細明體", 13F);
            this.label3.Location = new System.Drawing.Point(81, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "密碼 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Font = new System.Drawing.Font("新細明體", 13F);
            this.label4.Location = new System.Drawing.Point(80, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "帳號 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1_PasswordOnduty
            // 
            this.txt1_PasswordOnduty.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt1_PasswordOnduty.Location = new System.Drawing.Point(163, 274);
            this.txt1_PasswordOnduty.Name = "txt1_PasswordOnduty";
            this.txt1_PasswordOnduty.PasswordChar = '*';
            this.txt1_PasswordOnduty.Size = new System.Drawing.Size(264, 39);
            this.txt1_PasswordOnduty.TabIndex = 25;
            // 
            // txt1_LoginOnduty
            // 
            this.txt1_LoginOnduty.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt1_LoginOnduty.Location = new System.Drawing.Point(163, 218);
            this.txt1_LoginOnduty.Name = "txt1_LoginOnduty";
            this.txt1_LoginOnduty.Size = new System.Drawing.Size(264, 39);
            this.txt1_LoginOnduty.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btn1_LoginOnduty
            // 
            this.btn1_LoginOnduty.Location = new System.Drawing.Point(94, 367);
            this.btn1_LoginOnduty.Name = "btn1_LoginOnduty";
            this.btn1_LoginOnduty.Size = new System.Drawing.Size(333, 41);
            this.btn1_LoginOnduty.TabIndex = 22;
            this.btn1_LoginOnduty.Text = "登入";
            this.btn1_LoginOnduty.UseVisualStyleBackColor = true;
            this.btn1_LoginOnduty.Click += new System.EventHandler(this.btn1_LoginOnduty_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txt1_PasswordSystem);
            this.tabPage3.Controls.Add(this.txt1_LoginSystem);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.btn1_LoginSystem);
            this.tabPage3.Font = new System.Drawing.Font("新細明體", 13F);
            this.tabPage3.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(536, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "系統管理";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.Font = new System.Drawing.Font("新細明體", 13F);
            this.label5.Location = new System.Drawing.Point(81, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "密碼 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSlateGray;
            this.label6.Font = new System.Drawing.Font("新細明體", 13F);
            this.label6.Location = new System.Drawing.Point(80, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "帳號 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1_PasswordSystem
            // 
            this.txt1_PasswordSystem.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt1_PasswordSystem.Location = new System.Drawing.Point(163, 274);
            this.txt1_PasswordSystem.Name = "txt1_PasswordSystem";
            this.txt1_PasswordSystem.PasswordChar = '*';
            this.txt1_PasswordSystem.Size = new System.Drawing.Size(264, 39);
            this.txt1_PasswordSystem.TabIndex = 19;
            // 
            // txt1_LoginSystem
            // 
            this.txt1_LoginSystem.Font = new System.Drawing.Font("新細明體", 13F);
            this.txt1_LoginSystem.Location = new System.Drawing.Point(163, 218);
            this.txt1_LoginSystem.Name = "txt1_LoginSystem";
            this.txt1_LoginSystem.Size = new System.Drawing.Size(264, 39);
            this.txt1_LoginSystem.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(64, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // btn1_LoginSystem
            // 
            this.btn1_LoginSystem.Location = new System.Drawing.Point(94, 367);
            this.btn1_LoginSystem.Name = "btn1_LoginSystem";
            this.btn1_LoginSystem.Size = new System.Drawing.Size(333, 41);
            this.btn1_LoginSystem.TabIndex = 16;
            this.btn1_LoginSystem.Text = "登入";
            this.btn1_LoginSystem.UseVisualStyleBackColor = true;
            this.btn1_LoginSystem.Click += new System.EventHandler(this.btn1_LoginSystem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(528, 600);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1_LoginUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt1_PasswordUser;
        private System.Windows.Forms.TextBox txt1_LoginUser;
        private System.Windows.Forms.TextBox txt1_PasswordSystem;
        private System.Windows.Forms.TextBox txt1_LoginSystem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn1_LoginSystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1_PasswordOnduty;
        private System.Windows.Forms.TextBox txt1_LoginOnduty;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn1_LoginOnduty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}