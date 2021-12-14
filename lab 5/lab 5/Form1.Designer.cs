namespace lab_5
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mednamebox = new System.Windows.Forms.MaskedTextBox();
            this.checkcodebox = new System.Windows.Forms.MaskedTextBox();
            this.medsalequantity = new System.Windows.Forms.MaskedTextBox();
            this.balanceaddbox = new System.Windows.Forms.MaskedTextBox();
            this.medcodebox = new System.Windows.Forms.MaskedTextBox();
            this.medquantitybox = new System.Windows.Forms.MaskedTextBox();
            this.medpricebox = new System.Windows.Forms.MaskedTextBox();
            this.Addmedicine = new System.Windows.Forms.Button();
            this.addaccount = new System.Windows.Forms.Button();
            this.salemed = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.medstockbox = new System.Windows.Forms.MaskedTextBox();
            this.showQuantity = new System.Windows.Forms.Label();
            this.showstock = new System.Windows.Forms.Button();
            this.accountbalance = new System.Windows.Forms.Label();
            this.showaccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock show";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "medicine Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medicine code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sale balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "add balance;";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "medicine code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Medicine Quantity ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "medicine price";
            // 
            // mednamebox
            // 
            this.mednamebox.Location = new System.Drawing.Point(129, 48);
            this.mednamebox.Name = "mednamebox";
            this.mednamebox.Size = new System.Drawing.Size(100, 22);
            this.mednamebox.TabIndex = 10;
            // 
            // checkcodebox
            // 
            this.checkcodebox.Location = new System.Drawing.Point(563, 147);
            this.checkcodebox.Name = "checkcodebox";
            this.checkcodebox.Size = new System.Drawing.Size(100, 22);
            this.checkcodebox.TabIndex = 12;
            // 
            // medsalequantity
            // 
            this.medsalequantity.Location = new System.Drawing.Point(563, 190);
            this.medsalequantity.Name = "medsalequantity";
            this.medsalequantity.Size = new System.Drawing.Size(100, 22);
            this.medsalequantity.TabIndex = 13;
            // 
            // balanceaddbox
            // 
            this.balanceaddbox.Location = new System.Drawing.Point(422, 45);
            this.balanceaddbox.Name = "balanceaddbox";
            this.balanceaddbox.Size = new System.Drawing.Size(100, 22);
            this.balanceaddbox.TabIndex = 14;
            // 
            // medcodebox
            // 
            this.medcodebox.Location = new System.Drawing.Point(129, 162);
            this.medcodebox.Name = "medcodebox";
            this.medcodebox.Size = new System.Drawing.Size(100, 22);
            this.medcodebox.TabIndex = 15;
            // 
            // medquantitybox
            // 
            this.medquantitybox.Location = new System.Drawing.Point(129, 125);
            this.medquantitybox.Name = "medquantitybox";
            this.medquantitybox.Size = new System.Drawing.Size(100, 22);
            this.medquantitybox.TabIndex = 16;
            // 
            // medpricebox
            // 
            this.medpricebox.Location = new System.Drawing.Point(129, 88);
            this.medpricebox.Name = "medpricebox";
            this.medpricebox.Size = new System.Drawing.Size(100, 22);
            this.medpricebox.TabIndex = 17;
            // 
            // Addmedicine
            // 
            this.Addmedicine.Location = new System.Drawing.Point(66, 214);
            this.Addmedicine.Name = "Addmedicine";
            this.Addmedicine.Size = new System.Drawing.Size(121, 43);
            this.Addmedicine.TabIndex = 18;
            this.Addmedicine.Text = "add medicine";
            this.Addmedicine.UseVisualStyleBackColor = true;
            this.Addmedicine.Click += new System.EventHandler(this.Addmedicine_Click);
            // 
            // addaccount
            // 
            this.addaccount.Location = new System.Drawing.Point(572, 45);
            this.addaccount.Name = "addaccount";
            this.addaccount.Size = new System.Drawing.Size(102, 23);
            this.addaccount.TabIndex = 19;
            this.addaccount.Text = "add balance";
            this.addaccount.UseVisualStyleBackColor = true;
            this.addaccount.Click += new System.EventHandler(this.addaccount_Click);
            // 
            // salemed
            // 
            this.salemed.Location = new System.Drawing.Point(482, 224);
            this.salemed.Name = "salemed";
            this.salemed.Size = new System.Drawing.Size(134, 23);
            this.salemed.TabIndex = 20;
            this.salemed.Text = "sale medicine";
            this.salemed.UseVisualStyleBackColor = true;
            this.salemed.Click += new System.EventHandler(this.salemed_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Medicine code:";
            // 
            // medstockbox
            // 
            this.medstockbox.Location = new System.Drawing.Point(524, 296);
            this.medstockbox.Name = "medstockbox";
            this.medstockbox.Size = new System.Drawing.Size(100, 22);
            this.medstockbox.TabIndex = 22;
            // 
            // showQuantity
            // 
            this.showQuantity.AutoSize = true;
            this.showQuantity.Location = new System.Drawing.Point(421, 343);
            this.showQuantity.Name = "showQuantity";
            this.showQuantity.Size = new System.Drawing.Size(58, 16);
            this.showQuantity.TabIndex = 23;
            this.showQuantity.Text = "Quantity:";
            // 
            // showstock
            // 
            this.showstock.Location = new System.Drawing.Point(460, 373);
            this.showstock.Name = "showstock";
            this.showstock.Size = new System.Drawing.Size(83, 23);
            this.showstock.TabIndex = 24;
            this.showstock.Text = "show stock";
            this.showstock.UseVisualStyleBackColor = true;
            this.showstock.Click += new System.EventHandler(this.showstock_Click);
            // 
            // accountbalance
            // 
            this.accountbalance.AutoSize = true;
            this.accountbalance.Location = new System.Drawing.Point(29, 318);
            this.accountbalance.Name = "accountbalance";
            this.accountbalance.Size = new System.Drawing.Size(114, 16);
            this.accountbalance.TabIndex = 25;
            this.accountbalance.Text = "accoount balance";
            // 
            // showaccount
            // 
            this.showaccount.Location = new System.Drawing.Point(36, 352);
            this.showaccount.Name = "showaccount";
            this.showaccount.Size = new System.Drawing.Size(75, 23);
            this.showaccount.TabIndex = 26;
            this.showaccount.Text = "show account";
            this.showaccount.UseVisualStyleBackColor = true;
            this.showaccount.Click += new System.EventHandler(this.showaccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showaccount);
            this.Controls.Add(this.accountbalance);
            this.Controls.Add(this.showstock);
            this.Controls.Add(this.showQuantity);
            this.Controls.Add(this.medstockbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.salemed);
            this.Controls.Add(this.addaccount);
            this.Controls.Add(this.Addmedicine);
            this.Controls.Add(this.medpricebox);
            this.Controls.Add(this.medquantitybox);
            this.Controls.Add(this.medcodebox);
            this.Controls.Add(this.balanceaddbox);
            this.Controls.Add(this.medsalequantity);
            this.Controls.Add(this.checkcodebox);
            this.Controls.Add(this.mednamebox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mednamebox;
        private System.Windows.Forms.MaskedTextBox checkcodebox;
        private System.Windows.Forms.MaskedTextBox medsalequantity;
        private System.Windows.Forms.MaskedTextBox balanceaddbox;
        private System.Windows.Forms.MaskedTextBox medcodebox;
        private System.Windows.Forms.MaskedTextBox medquantitybox;
        private System.Windows.Forms.MaskedTextBox medpricebox;
        private System.Windows.Forms.Button Addmedicine;
        private System.Windows.Forms.Button addaccount;
        private System.Windows.Forms.Button salemed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox medstockbox;
        private System.Windows.Forms.Label showQuantity;
        private System.Windows.Forms.Button showstock;
        private System.Windows.Forms.Label accountbalance;
        private System.Windows.Forms.Button showaccount;
    }
}

