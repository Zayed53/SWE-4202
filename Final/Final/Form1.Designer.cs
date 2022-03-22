namespace Final
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
            this.namea = new System.Windows.Forms.ListBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchId = new System.Windows.Forms.Button();
            this.Showhistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // namea
            // 
            this.namea.FormattingEnabled = true;
            this.namea.ItemHeight = 16;
            this.namea.Location = new System.Drawing.Point(12, 12);
            this.namea.Name = "namea";
            this.namea.Size = new System.Drawing.Size(308, 420);
            this.namea.TabIndex = 1;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(374, 12);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(198, 22);
            this.searchbox.TabIndex = 2;
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(438, 40);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(75, 23);
            this.searchId.TabIndex = 4;
            this.searchId.Text = "Search";
            this.searchId.UseVisualStyleBackColor = true;
            this.searchId.Click += new System.EventHandler(this.searchId_Click);
            // 
            // Showhistory
            // 
            this.Showhistory.FormattingEnabled = true;
            this.Showhistory.ItemHeight = 16;
            this.Showhistory.Location = new System.Drawing.Point(374, 98);
            this.Showhistory.Name = "Showhistory";
            this.Showhistory.Size = new System.Drawing.Size(198, 292);
            this.Showhistory.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Showhistory);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.namea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox namea;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button searchId;
        private System.Windows.Forms.ListBox Showhistory;
    }
}

