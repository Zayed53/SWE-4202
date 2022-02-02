namespace lab07
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depositebox = new System.Windows.Forms.TextBox();
            this.account_typecombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.infrmaccountidcombo = new System.Windows.Forms.ComboBox();
            this.infrmacctypecombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showinformation = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.depositetypecombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.depositeaccountcombo = new System.Windows.Forms.ComboBox();
            this.Deposite = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.newdeposite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Withdrawtypecombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Withdrawaccountcombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.withdrawamntbox = new System.Windows.Forms.TextBox();
            this.Withdraw = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lastwithbx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.historytypecombo = new System.Windows.Forms.ComboBox();
            this.historynocombo = new System.Windows.Forms.ComboBox();
            this.historylist = new System.Windows.Forms.ListBox();
            this.History = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create acccount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Information";
            // 
            // depositebox
            // 
            this.depositebox.Location = new System.Drawing.Point(109, 73);
            this.depositebox.Name = "depositebox";
            this.depositebox.Size = new System.Drawing.Size(100, 22);
            this.depositebox.TabIndex = 4;
            // 
            // account_typecombo
            // 
            this.account_typecombo.FormattingEnabled = true;
            this.account_typecombo.Items.AddRange(new object[] {
            "Current",
            "Savings",
            "Loan"});
            this.account_typecombo.Location = new System.Drawing.Point(109, 38);
            this.account_typecombo.Name = "account_typecombo";
            this.account_typecombo.Size = new System.Drawing.Size(121, 24);
            this.account_typecombo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account Type";
            // 
            // infrmaccountidcombo
            // 
            this.infrmaccountidcombo.FormattingEnabled = true;
            this.infrmaccountidcombo.Location = new System.Drawing.Point(390, 71);
            this.infrmaccountidcombo.Name = "infrmaccountidcombo";
            this.infrmaccountidcombo.Size = new System.Drawing.Size(121, 24);
            this.infrmaccountidcombo.TabIndex = 10;
            // 
            // infrmacctypecombo
            // 
            this.infrmacctypecombo.FormattingEnabled = true;
            this.infrmacctypecombo.Items.AddRange(new object[] {
            "Current",
            "Savings",
            "Loan"});
            this.infrmacctypecombo.Location = new System.Drawing.Point(390, 41);
            this.infrmacctypecombo.Name = "infrmacctypecombo";
            this.infrmacctypecombo.Size = new System.Drawing.Size(121, 24);
            this.infrmacctypecombo.TabIndex = 11;
            this.infrmacctypecombo.SelectedIndexChanged += new System.EventHandler(this.infrmacctypecombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Account no:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(286, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 36);
            this.listBox1.TabIndex = 13;
            // 
            // showinformation
            // 
            this.showinformation.Location = new System.Drawing.Point(364, 156);
            this.showinformation.Name = "showinformation";
            this.showinformation.Size = new System.Drawing.Size(123, 23);
            this.showinformation.TabIndex = 14;
            this.showinformation.Text = "Show information";
            this.showinformation.UseVisualStyleBackColor = true;
            this.showinformation.Click += new System.EventHandler(this.showinformation_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(47, 114);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 15;
            this.Create.Text = "Create account";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "deposite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Deposite\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Account Type";
            // 
            // depositetypecombo
            // 
            this.depositetypecombo.FormattingEnabled = true;
            this.depositetypecombo.Items.AddRange(new object[] {
            "Current",
            "Savings",
            "Loan"});
            this.depositetypecombo.Location = new System.Drawing.Point(137, 257);
            this.depositetypecombo.Name = "depositetypecombo";
            this.depositetypecombo.Size = new System.Drawing.Size(121, 24);
            this.depositetypecombo.TabIndex = 19;
            this.depositetypecombo.SelectedIndexChanged += new System.EventHandler(this.depositetype_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Account no:";
            // 
            // depositeaccountcombo
            // 
            this.depositeaccountcombo.FormattingEnabled = true;
            this.depositeaccountcombo.Location = new System.Drawing.Point(137, 299);
            this.depositeaccountcombo.Name = "depositeaccountcombo";
            this.depositeaccountcombo.Size = new System.Drawing.Size(121, 24);
            this.depositeaccountcombo.TabIndex = 21;
            // 
            // Deposite
            // 
            this.Deposite.Location = new System.Drawing.Point(84, 415);
            this.Deposite.Name = "Deposite";
            this.Deposite.Size = new System.Drawing.Size(75, 23);
            this.Deposite.TabIndex = 22;
            this.Deposite.Text = "Deposite";
            this.Deposite.UseVisualStyleBackColor = true;
            this.Deposite.Click += new System.EventHandler(this.Deposite_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "deposite";
            // 
            // newdeposite
            // 
            this.newdeposite.Location = new System.Drawing.Point(137, 338);
            this.newdeposite.Name = "newdeposite";
            this.newdeposite.Size = new System.Drawing.Size(100, 22);
            this.newdeposite.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Withdraw";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Account Type";
            // 
            // Withdrawtypecombo
            // 
            this.Withdrawtypecombo.FormattingEnabled = true;
            this.Withdrawtypecombo.Items.AddRange(new object[] {
            "Current",
            "Savings",
            "Loan"});
            this.Withdrawtypecombo.Location = new System.Drawing.Point(457, 254);
            this.Withdrawtypecombo.Name = "Withdrawtypecombo";
            this.Withdrawtypecombo.Size = new System.Drawing.Size(121, 24);
            this.Withdrawtypecombo.TabIndex = 27;
            this.Withdrawtypecombo.SelectedIndexChanged += new System.EventHandler(this.Withdrawtypecombo_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Account no:";
            // 
            // Withdrawaccountcombo
            // 
            this.Withdrawaccountcombo.FormattingEnabled = true;
            this.Withdrawaccountcombo.Location = new System.Drawing.Point(457, 296);
            this.Withdrawaccountcombo.Name = "Withdrawaccountcombo";
            this.Withdrawaccountcombo.Size = new System.Drawing.Size(121, 24);
            this.Withdrawaccountcombo.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Withdraw";
            // 
            // withdrawamntbox
            // 
            this.withdrawamntbox.Location = new System.Drawing.Point(457, 335);
            this.withdrawamntbox.Name = "withdrawamntbox";
            this.withdrawamntbox.Size = new System.Drawing.Size(100, 22);
            this.withdrawamntbox.TabIndex = 31;
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(412, 426);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(75, 23);
            this.Withdraw.TabIndex = 32;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "last Withdrawn";
            // 
            // lastwithbx
            // 
            this.lastwithbx.Location = new System.Drawing.Point(460, 366);
            this.lastwithbx.Name = "lastwithbx";
            this.lastwithbx.Size = new System.Drawing.Size(100, 22);
            this.lastwithbx.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(683, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 25);
            this.label16.TabIndex = 35;
            this.label16.Text = "History";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(685, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "Account Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(686, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 37;
            this.label18.Text = "Account no:";
            // 
            // historytypecombo
            // 
            this.historytypecombo.FormattingEnabled = true;
            this.historytypecombo.Items.AddRange(new object[] {
            "Current",
            "Savings",
            "Loan"});
            this.historytypecombo.Location = new System.Drawing.Point(793, 61);
            this.historytypecombo.Name = "historytypecombo";
            this.historytypecombo.Size = new System.Drawing.Size(121, 24);
            this.historytypecombo.TabIndex = 39;
            this.historytypecombo.SelectedIndexChanged += new System.EventHandler(this.historytypecombo_SelectedIndexChanged);
            // 
            // historynocombo
            // 
            this.historynocombo.FormattingEnabled = true;
            this.historynocombo.Location = new System.Drawing.Point(793, 93);
            this.historynocombo.Name = "historynocombo";
            this.historynocombo.Size = new System.Drawing.Size(121, 24);
            this.historynocombo.TabIndex = 40;
            // 
            // historylist
            // 
            this.historylist.FormattingEnabled = true;
            this.historylist.ItemHeight = 16;
            this.historylist.Location = new System.Drawing.Point(688, 132);
            this.historylist.Name = "historylist";
            this.historylist.Size = new System.Drawing.Size(371, 36);
            this.historylist.TabIndex = 38;
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(793, 190);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(123, 23);
            this.History.TabIndex = 41;
            this.History.Text = "Show History";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 372);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 372);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 16);
            this.label19.TabIndex = 42;
            this.label19.Text = "date:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(414, 397);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 16);
            this.label20.TabIndex = 44;
            this.label20.Text = "date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(457, 394);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 486);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.History);
            this.Controls.Add(this.historynocombo);
            this.Controls.Add(this.historytypecombo);
            this.Controls.Add(this.historylist);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lastwithbx);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.withdrawamntbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Withdrawaccountcombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Withdrawtypecombo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.newdeposite);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Deposite);
            this.Controls.Add(this.depositeaccountcombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.depositetypecombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.showinformation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infrmacctypecombo);
            this.Controls.Add(this.infrmaccountidcombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.account_typecombo);
            this.Controls.Add(this.depositebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depositebox;
        private System.Windows.Forms.ComboBox account_typecombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox infrmaccountidcombo;
        private System.Windows.Forms.ComboBox infrmacctypecombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showinformation;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox depositetypecombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox depositeaccountcombo;
        private System.Windows.Forms.Button Deposite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newdeposite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Withdrawtypecombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Withdrawaccountcombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox withdrawamntbox;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lastwithbx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox historytypecombo;
        private System.Windows.Forms.ComboBox historynocombo;
        private System.Windows.Forms.ListBox historylist;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

