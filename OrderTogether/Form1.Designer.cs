
namespace OrderTogether
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rBtn_pay = new System.Windows.Forms.RadioButton();
            this.rBtn_notPay = new System.Windows.Forms.RadioButton();
            this.cBox_className = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_shopName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_classOwner = new System.Windows.Forms.Label();
            this.num_count = new System.Windows.Forms.NumericUpDown();
            this.lBox_orderReview = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_randomShopMenu = new System.Windows.Forms.Button();
            this.btn_addToReview = new System.Windows.Forms.Button();
            this.btn_singleRemove = new System.Windows.Forms.Button();
            this.btn_removeAll = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_orderConfirm = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cBox_shopMenu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBox_users = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_ouputList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_notMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ouputList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "今日班級負責人:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名:";
            // 
            // tBox_UserName
            // 
            this.tBox_UserName.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tBox_UserName.Location = new System.Drawing.Point(1603, 638);
            this.tBox_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox_UserName.Name = "tBox_UserName";
            this.tBox_UserName.Size = new System.Drawing.Size(225, 39);
            this.tBox_UserName.TabIndex = 2;
            this.tBox_UserName.Visible = false;
            this.tBox_UserName.TextChanged += new System.EventHandler(this.tBox_UserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "班級:";
            // 
            // rBtn_pay
            // 
            this.rBtn_pay.AutoSize = true;
            this.rBtn_pay.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn_pay.Location = new System.Drawing.Point(26, 489);
            this.rBtn_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_pay.Name = "rBtn_pay";
            this.rBtn_pay.Size = new System.Drawing.Size(115, 30);
            this.rBtn_pay.TabIndex = 5;
            this.rBtn_pay.TabStop = true;
            this.rBtn_pay.Text = "先付款";
            this.rBtn_pay.UseVisualStyleBackColor = true;
            this.rBtn_pay.CheckedChanged += new System.EventHandler(this.rBtn_pay_CheckedChanged);
            // 
            // rBtn_notPay
            // 
            this.rBtn_notPay.AutoSize = true;
            this.rBtn_notPay.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn_notPay.Location = new System.Drawing.Point(165, 489);
            this.rBtn_notPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_notPay.Name = "rBtn_notPay";
            this.rBtn_notPay.Size = new System.Drawing.Size(115, 30);
            this.rBtn_notPay.TabIndex = 6;
            this.rBtn_notPay.TabStop = true;
            this.rBtn_notPay.Text = "後付款";
            this.rBtn_notPay.UseVisualStyleBackColor = true;
            this.rBtn_notPay.CheckedChanged += new System.EventHandler(this.rBtn_notPay_CheckedChanged);
            // 
            // cBox_className
            // 
            this.cBox_className.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_className.FormattingEnabled = true;
            this.cBox_className.Location = new System.Drawing.Point(93, 37);
            this.cBox_className.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_className.Name = "cBox_className";
            this.cBox_className.Size = new System.Drawing.Size(225, 34);
            this.cBox_className.TabIndex = 7;
            this.cBox_className.SelectedIndexChanged += new System.EventHandler(this.cBox_className_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "今日餐廳選擇 (每日隨機三間)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(8, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "餐點選擇";
            // 
            // cBox_shopName
            // 
            this.cBox_shopName.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_shopName.FormattingEnabled = true;
            this.cBox_shopName.Location = new System.Drawing.Point(12, 162);
            this.cBox_shopName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_shopName.Name = "cBox_shopName";
            this.cBox_shopName.Size = new System.Drawing.Size(414, 34);
            this.cBox_shopName.TabIndex = 11;
            this.cBox_shopName.SelectedIndexChanged += new System.EventHandler(this.cBox_shopName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "數量:";
            // 
            // lbl_classOwner
            // 
            this.lbl_classOwner.AutoSize = true;
            this.lbl_classOwner.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_classOwner.Location = new System.Drawing.Point(252, 667);
            this.lbl_classOwner.Name = "lbl_classOwner";
            this.lbl_classOwner.Size = new System.Drawing.Size(90, 26);
            this.lbl_classOwner.TabIndex = 14;
            this.lbl_classOwner.Text = "負責人";
            // 
            // num_count
            // 
            this.num_count.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num_count.Location = new System.Drawing.Point(93, 313);
            this.num_count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(61, 39);
            this.num_count.TabIndex = 15;
            this.num_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lBox_orderReview
            // 
            this.lBox_orderReview.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_orderReview.FormattingEnabled = true;
            this.lBox_orderReview.ItemHeight = 26;
            this.lBox_orderReview.Location = new System.Drawing.Point(1603, 107);
            this.lBox_orderReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBox_orderReview.Name = "lBox_orderReview";
            this.lBox_orderReview.Size = new System.Drawing.Size(817, 420);
            this.lBox_orderReview.TabIndex = 17;
            this.lBox_orderReview.Visible = false;
            this.lBox_orderReview.SelectedIndexChanged += new System.EventHandler(this.lBox_orderReview_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(9, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "有選擇障礙?";
            // 
            // btn_randomShopMenu
            // 
            this.btn_randomShopMenu.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_randomShopMenu.Location = new System.Drawing.Point(212, 361);
            this.btn_randomShopMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_randomShopMenu.Name = "btn_randomShopMenu";
            this.btn_randomShopMenu.Size = new System.Drawing.Size(232, 57);
            this.btn_randomShopMenu.TabIndex = 19;
            this.btn_randomShopMenu.Text = "給我隨便來一種 !";
            this.btn_randomShopMenu.UseVisualStyleBackColor = true;
            this.btn_randomShopMenu.Click += new System.EventHandler(this.btn_randomShopMenu_Click);
            // 
            // btn_addToReview
            // 
            this.btn_addToReview.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addToReview.Location = new System.Drawing.Point(21, 530);
            this.btn_addToReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addToReview.Name = "btn_addToReview";
            this.btn_addToReview.Size = new System.Drawing.Size(510, 48);
            this.btn_addToReview.TabIndex = 20;
            this.btn_addToReview.Text = "加入訂單 >>";
            this.btn_addToReview.UseVisualStyleBackColor = true;
            this.btn_addToReview.Click += new System.EventHandler(this.btn_addToReview_Click);
            // 
            // btn_singleRemove
            // 
            this.btn_singleRemove.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_singleRemove.Location = new System.Drawing.Point(19, 533);
            this.btn_singleRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_singleRemove.Name = "btn_singleRemove";
            this.btn_singleRemove.Size = new System.Drawing.Size(288, 48);
            this.btn_singleRemove.TabIndex = 21;
            this.btn_singleRemove.Text = "<< 從訂單移除";
            this.btn_singleRemove.UseVisualStyleBackColor = true;
            this.btn_singleRemove.Click += new System.EventHandler(this.btn_singleRemove_Click);
            // 
            // btn_removeAll
            // 
            this.btn_removeAll.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_removeAll.Location = new System.Drawing.Point(323, 533);
            this.btn_removeAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeAll.Name = "btn_removeAll";
            this.btn_removeAll.Size = new System.Drawing.Size(54, 48);
            this.btn_removeAll.TabIndex = 22;
            this.btn_removeAll.Text = "一鍵清空";
            this.btn_removeAll.UseVisualStyleBackColor = true;
            this.btn_removeAll.Click += new System.EventHandler(this.btn_removeAll_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(268, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "單價:";
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_price.Location = new System.Drawing.Point(346, 310);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(75, 35);
            this.lbl_price.TabIndex = 26;
            this.lbl_price.Text = "XX";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_date.Location = new System.Drawing.Point(708, 667);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(158, 26);
            this.lbl_date.TabIndex = 29;
            this.lbl_date.Text = "20XX/XX/XX";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(618, 667);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 26);
            this.label16.TabIndex = 28;
            this.label16.Text = "日期:";
            // 
            // btn_orderConfirm
            // 
            this.btn_orderConfirm.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_orderConfirm.Location = new System.Drawing.Point(540, 530);
            this.btn_orderConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_orderConfirm.Name = "btn_orderConfirm";
            this.btn_orderConfirm.Size = new System.Drawing.Size(347, 48);
            this.btn_orderConfirm.TabIndex = 30;
            this.btn_orderConfirm.Text = "確認完畢 >>";
            this.btn_orderConfirm.UseVisualStyleBackColor = true;
            this.btn_orderConfirm.Click += new System.EventHandler(this.btn_orderConfirm_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(16, 454);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 26);
            this.label17.TabIndex = 31;
            this.label17.Text = "付款方式";
            // 
            // cBox_shopMenu
            // 
            this.cBox_shopMenu.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_shopMenu.FormattingEnabled = true;
            this.cBox_shopMenu.Location = new System.Drawing.Point(13, 244);
            this.cBox_shopMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_shopMenu.Name = "cBox_shopMenu";
            this.cBox_shopMenu.Size = new System.Drawing.Size(411, 34);
            this.cBox_shopMenu.TabIndex = 37;
            this.cBox_shopMenu.SelectedIndexChanged += new System.EventHandler(this.cBox_shopMenu_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBox_users);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cBox_shopMenu);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lbl_price);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_addToReview);
            this.groupBox1.Controls.Add(this.btn_randomShopMenu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.num_count);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cBox_shopName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBox_className);
            this.groupBox1.Controls.Add(this.rBtn_notPay);
            this.groupBox1.Controls.Add(this.rBtn_pay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(11, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(554, 593);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂購人資訊";
            // 
            // cBox_users
            // 
            this.cBox_users.FormattingEnabled = true;
            this.cBox_users.Location = new System.Drawing.Point(93, 81);
            this.cBox_users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_users.Name = "cBox_users";
            this.cBox_users.Size = new System.Drawing.Size(225, 34);
            this.cBox_users.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(421, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 35);
            this.label8.TabIndex = 38;
            this.label8.Text = "元";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_ouputList);
            this.groupBox2.Controls.Add(this.btn_orderConfirm);
            this.groupBox2.Controls.Add(this.btn_singleRemove);
            this.groupBox2.Controls.Add(this.btn_removeAll);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(588, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(907, 593);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "班級訂購資訊預覽";
            // 
            // dGV_ouputList
            // 
            this.dGV_ouputList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ouputList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ouputList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ouputList.Location = new System.Drawing.Point(19, 53);
            this.dGV_ouputList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_ouputList.Name = "dGV_ouputList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ouputList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_ouputList.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dGV_ouputList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_ouputList.RowTemplate.Height = 31;
            this.dGV_ouputList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ouputList.Size = new System.Drawing.Size(868, 461);
            this.dGV_ouputList.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(654, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 26);
            this.label4.TabIndex = 38;
            this.label4.Text = "團體訂餐系統";
            // 
            // btn_notMe
            // 
            this.btn_notMe.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_notMe.Location = new System.Drawing.Point(348, 662);
            this.btn_notMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_notMe.Name = "btn_notMe";
            this.btn_notMe.Size = new System.Drawing.Size(214, 37);
            this.btn_notMe.TabIndex = 38;
            this.btn_notMe.Text = "我不是負責人";
            this.btn_notMe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1525, 714);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_classOwner);
            this.Controls.Add(this.btn_notMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBox_UserName);
            this.Controls.Add(this.lBox_orderReview);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "團體訂餐系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ouputList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBtn_pay;
        private System.Windows.Forms.RadioButton rBtn_notPay;
        private System.Windows.Forms.ComboBox cBox_className;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_shopName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_classOwner;
        private System.Windows.Forms.NumericUpDown num_count;
        private System.Windows.Forms.ListBox lBox_orderReview;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_randomShopMenu;
        private System.Windows.Forms.Button btn_addToReview;
        private System.Windows.Forms.Button btn_singleRemove;
        private System.Windows.Forms.Button btn_removeAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_orderConfirm;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cBox_shopMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_notMe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBox_users;
        private System.Windows.Forms.DataGridView dGV_ouputList;
    }
}

