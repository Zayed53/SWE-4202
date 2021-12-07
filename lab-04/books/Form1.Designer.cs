namespace books
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BookIDtxt = new System.Windows.Forms.TextBox();
            this.BookISBNtxt = new System.Windows.Forms.TextBox();
            this.Bookquantitytxt = new System.Windows.Forms.TextBox();
            this.Bookpublishertxt = new System.Windows.Forms.TextBox();
            this.Bookauthortxt = new System.Windows.Forms.TextBox();
            this.BookTittletxt = new System.Windows.Forms.TextBox();
            this.Addstudybook = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.BookGenretxt = new System.Windows.Forms.TextBox();
            this.articleID = new System.Windows.Forms.MaskedTextBox();
            this.articleconferencetxt = new System.Windows.Forms.MaskedTextBox();
            this.articlepublisherdatetxt = new System.Windows.Forms.MaskedTextBox();
            this.articleDOItxt = new System.Windows.Forms.MaskedTextBox();
            this.articlequantitytxt = new System.Windows.Forms.MaskedTextBox();
            this.articlepublishertxt = new System.Windows.Forms.MaskedTextBox();
            this.articleauthortxt = new System.Windows.Forms.MaskedTextBox();
            this.articletittletxt = new System.Windows.Forms.MaskedTextBox();
            this.Addresearcharticle = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.borrowbook = new System.Windows.Forms.MaskedTextBox();
            this.articleTxt = new System.Windows.Forms.MaskedTextBox();
            this.borrowarticlebutton = new System.Windows.Forms.Button();
            this.borrowbookbutton = new System.Windows.Forms.Button();
            this.Showbook = new System.Windows.Forms.Button();
            this.showbookslist = new System.Windows.Forms.ListBox();
            this.showarticles = new System.Windows.Forms.Button();
            this.Showarticleslist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tittle:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(243, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 312);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Publisher:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Author:";
            // 
            // BookIDtxt
            // 
            this.BookIDtxt.Location = new System.Drawing.Point(120, 16);
            this.BookIDtxt.Name = "BookIDtxt";
            this.BookIDtxt.Size = new System.Drawing.Size(100, 22);
            this.BookIDtxt.TabIndex = 9;
            // 
            // BookISBNtxt
            // 
            this.BookISBNtxt.Location = new System.Drawing.Point(120, 195);
            this.BookISBNtxt.Name = "BookISBNtxt";
            this.BookISBNtxt.Size = new System.Drawing.Size(100, 22);
            this.BookISBNtxt.TabIndex = 10;
            // 
            // Bookquantitytxt
            // 
            this.Bookquantitytxt.Location = new System.Drawing.Point(120, 153);
            this.Bookquantitytxt.Name = "Bookquantitytxt";
            this.Bookquantitytxt.Size = new System.Drawing.Size(100, 22);
            this.Bookquantitytxt.TabIndex = 11;
            // 
            // Bookpublishertxt
            // 
            this.Bookpublishertxt.Location = new System.Drawing.Point(120, 120);
            this.Bookpublishertxt.Name = "Bookpublishertxt";
            this.Bookpublishertxt.Size = new System.Drawing.Size(100, 22);
            this.Bookpublishertxt.TabIndex = 12;
            // 
            // Bookauthortxt
            // 
            this.Bookauthortxt.Location = new System.Drawing.Point(120, 90);
            this.Bookauthortxt.Name = "Bookauthortxt";
            this.Bookauthortxt.Size = new System.Drawing.Size(100, 22);
            this.Bookauthortxt.TabIndex = 13;
            // 
            // BookTittletxt
            // 
            this.BookTittletxt.Location = new System.Drawing.Point(120, 49);
            this.BookTittletxt.Name = "BookTittletxt";
            this.BookTittletxt.Size = new System.Drawing.Size(100, 22);
            this.BookTittletxt.TabIndex = 14;
            // 
            // Addstudybook
            // 
            this.Addstudybook.Location = new System.Drawing.Point(36, 258);
            this.Addstudybook.Name = "Addstudybook";
            this.Addstudybook.Size = new System.Drawing.Size(146, 23);
            this.Addstudybook.TabIndex = 15;
            this.Addstudybook.Text = "Add Study Book";
            this.Addstudybook.UseVisualStyleBackColor = true;
            this.Addstudybook.Click += new System.EventHandler(this.Addstudybook_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Article Id:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Book ID;";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(275, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Conference:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(275, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Publisher date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(275, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "DOI";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(275, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "Tittle:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(275, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "Author:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(275, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 16);
            this.label21.TabIndex = 28;
            this.label21.Text = "Publisher:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(275, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 16);
            this.label22.TabIndex = 29;
            this.label22.Text = "Quantity:";
            // 
            // BookGenretxt
            // 
            this.BookGenretxt.Location = new System.Drawing.Point(120, 230);
            this.BookGenretxt.Name = "BookGenretxt";
            this.BookGenretxt.Size = new System.Drawing.Size(100, 22);
            this.BookGenretxt.TabIndex = 30;
            // 
            // articleID
            // 
            this.articleID.Location = new System.Drawing.Point(397, 6);
            this.articleID.Name = "articleID";
            this.articleID.Size = new System.Drawing.Size(100, 22);
            this.articleID.TabIndex = 31;
            // 
            // articleconferencetxt
            // 
            this.articleconferencetxt.Location = new System.Drawing.Point(397, 255);
            this.articleconferencetxt.Name = "articleconferencetxt";
            this.articleconferencetxt.Size = new System.Drawing.Size(100, 22);
            this.articleconferencetxt.TabIndex = 32;
            // 
            // articlepublisherdatetxt
            // 
            this.articlepublisherdatetxt.Location = new System.Drawing.Point(397, 225);
            this.articlepublisherdatetxt.Name = "articlepublisherdatetxt";
            this.articlepublisherdatetxt.Size = new System.Drawing.Size(100, 22);
            this.articlepublisherdatetxt.TabIndex = 33;
            // 
            // articleDOItxt
            // 
            this.articleDOItxt.Location = new System.Drawing.Point(397, 195);
            this.articleDOItxt.Name = "articleDOItxt";
            this.articleDOItxt.Size = new System.Drawing.Size(100, 22);
            this.articleDOItxt.TabIndex = 34;
            // 
            // articlequantitytxt
            // 
            this.articlequantitytxt.Location = new System.Drawing.Point(397, 156);
            this.articlequantitytxt.Name = "articlequantitytxt";
            this.articlequantitytxt.Size = new System.Drawing.Size(100, 22);
            this.articlequantitytxt.TabIndex = 35;
            // 
            // articlepublishertxt
            // 
            this.articlepublishertxt.Location = new System.Drawing.Point(397, 117);
            this.articlepublishertxt.Name = "articlepublishertxt";
            this.articlepublishertxt.Size = new System.Drawing.Size(100, 22);
            this.articlepublishertxt.TabIndex = 36;
            // 
            // articleauthortxt
            // 
            this.articleauthortxt.Location = new System.Drawing.Point(397, 84);
            this.articleauthortxt.Name = "articleauthortxt";
            this.articleauthortxt.Size = new System.Drawing.Size(100, 22);
            this.articleauthortxt.TabIndex = 37;
            // 
            // articletittletxt
            // 
            this.articletittletxt.Location = new System.Drawing.Point(397, 43);
            this.articletittletxt.Name = "articletittletxt";
            this.articletittletxt.Size = new System.Drawing.Size(100, 22);
            this.articletittletxt.TabIndex = 38;
            // 
            // Addresearcharticle
            // 
            this.Addresearcharticle.Location = new System.Drawing.Point(278, 283);
            this.Addresearcharticle.Name = "Addresearcharticle";
            this.Addresearcharticle.Size = new System.Drawing.Size(174, 23);
            this.Addresearcharticle.TabIndex = 39;
            this.Addresearcharticle.Text = "ADD Research article";
            this.Addresearcharticle.UseVisualStyleBackColor = true;
            this.Addresearcharticle.Click += new System.EventHandler(this.Addresearcharticle_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(15, 321);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(517, 10);
            this.label23.TabIndex = 40;
            // 
            // borrowbook
            // 
            this.borrowbook.Location = new System.Drawing.Point(108, 364);
            this.borrowbook.Name = "borrowbook";
            this.borrowbook.Size = new System.Drawing.Size(100, 22);
            this.borrowbook.TabIndex = 41;
            // 
            // articleTxt
            // 
            this.articleTxt.Location = new System.Drawing.Point(352, 355);
            this.articleTxt.Name = "articleTxt";
            this.articleTxt.Size = new System.Drawing.Size(100, 22);
            this.articleTxt.TabIndex = 42;
            // 
            // borrowarticlebutton
            // 
            this.borrowarticlebutton.Location = new System.Drawing.Point(321, 412);
            this.borrowarticlebutton.Name = "borrowarticlebutton";
            this.borrowarticlebutton.Size = new System.Drawing.Size(75, 23);
            this.borrowarticlebutton.TabIndex = 43;
            this.borrowarticlebutton.Text = "Borrow";
            this.borrowarticlebutton.UseVisualStyleBackColor = true;
            this.borrowarticlebutton.Click += new System.EventHandler(this.borrowarticlebutton_Click);
            // 
            // borrowbookbutton
            // 
            this.borrowbookbutton.Location = new System.Drawing.Point(57, 412);
            this.borrowbookbutton.Name = "borrowbookbutton";
            this.borrowbookbutton.Size = new System.Drawing.Size(75, 23);
            this.borrowbookbutton.TabIndex = 44;
            this.borrowbookbutton.Text = "borrow";
            this.borrowbookbutton.UseVisualStyleBackColor = true;
            this.borrowbookbutton.Click += new System.EventHandler(this.borrowbookbutton_Click);
            // 
            // Showbook
            // 
            this.Showbook.Location = new System.Drawing.Point(692, 16);
            this.Showbook.Name = "Showbook";
            this.Showbook.Size = new System.Drawing.Size(136, 23);
            this.Showbook.TabIndex = 45;
            this.Showbook.Text = "show book";
            this.Showbook.UseVisualStyleBackColor = true;
            this.Showbook.Click += new System.EventHandler(this.Showbook_Click);
            // 
            // showbookslist
            // 
            this.showbookslist.FormattingEnabled = true;
            this.showbookslist.ItemHeight = 16;
            this.showbookslist.Location = new System.Drawing.Point(692, 70);
            this.showbookslist.Name = "showbookslist";
            this.showbookslist.Size = new System.Drawing.Size(680, 164);
            this.showbookslist.TabIndex = 46;
            // 
            // showarticles
            // 
            this.showarticles.Location = new System.Drawing.Point(692, 258);
            this.showarticles.Name = "showarticles";
            this.showarticles.Size = new System.Drawing.Size(136, 23);
            this.showarticles.TabIndex = 47;
            this.showarticles.Text = "show articles";
            this.showarticles.UseVisualStyleBackColor = true;
            this.showarticles.Click += new System.EventHandler(this.showarticles_Click);
            // 
            // Showarticleslist
            // 
            this.Showarticleslist.FormattingEnabled = true;
            this.Showarticleslist.ItemHeight = 16;
            this.Showarticleslist.Location = new System.Drawing.Point(692, 321);
            this.Showarticleslist.Name = "Showarticleslist";
            this.Showarticleslist.Size = new System.Drawing.Size(680, 132);
            this.Showarticleslist.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 547);
            this.Controls.Add(this.Showarticleslist);
            this.Controls.Add(this.showarticles);
            this.Controls.Add(this.showbookslist);
            this.Controls.Add(this.Showbook);
            this.Controls.Add(this.borrowbookbutton);
            this.Controls.Add(this.borrowarticlebutton);
            this.Controls.Add(this.articleTxt);
            this.Controls.Add(this.borrowbook);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Addresearcharticle);
            this.Controls.Add(this.articletittletxt);
            this.Controls.Add(this.articleauthortxt);
            this.Controls.Add(this.articlepublishertxt);
            this.Controls.Add(this.articlequantitytxt);
            this.Controls.Add(this.articleDOItxt);
            this.Controls.Add(this.articlepublisherdatetxt);
            this.Controls.Add(this.articleconferencetxt);
            this.Controls.Add(this.articleID);
            this.Controls.Add(this.BookGenretxt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Addstudybook);
            this.Controls.Add(this.BookTittletxt);
            this.Controls.Add(this.Bookauthortxt);
            this.Controls.Add(this.Bookpublishertxt);
            this.Controls.Add(this.Bookquantitytxt);
            this.Controls.Add(this.BookISBNtxt);
            this.Controls.Add(this.BookIDtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BookIDtxt;
        private System.Windows.Forms.TextBox BookISBNtxt;
        private System.Windows.Forms.TextBox Bookquantitytxt;
        private System.Windows.Forms.TextBox Bookpublishertxt;
        private System.Windows.Forms.TextBox Bookauthortxt;
        private System.Windows.Forms.TextBox BookTittletxt;
        private System.Windows.Forms.Button Addstudybook;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox BookGenretxt;
        private System.Windows.Forms.MaskedTextBox articleID;
        private System.Windows.Forms.MaskedTextBox articleconferencetxt;
        private System.Windows.Forms.MaskedTextBox articlepublisherdatetxt;
        private System.Windows.Forms.MaskedTextBox articleDOItxt;
        private System.Windows.Forms.MaskedTextBox articlequantitytxt;
        private System.Windows.Forms.MaskedTextBox articlepublishertxt;
        private System.Windows.Forms.MaskedTextBox articleauthortxt;
        private System.Windows.Forms.MaskedTextBox articletittletxt;
        private System.Windows.Forms.Button Addresearcharticle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox borrowbook;
        private System.Windows.Forms.MaskedTextBox articleTxt;
        private System.Windows.Forms.Button borrowarticlebutton;
        private System.Windows.Forms.Button borrowbookbutton;
        private System.Windows.Forms.Button Showbook;
        private System.Windows.Forms.ListBox showbookslist;
        private System.Windows.Forms.Button showarticles;
        private System.Windows.Forms.ListBox Showarticleslist;
    }
}

