namespace SSG_Winforms
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbBooksResult = new System.Windows.Forms.ListBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblChapter = new System.Windows.Forms.Label();
            this.lbChaptersResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(93, 15);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(311, 20);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookName_KeyDown);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(9, 18);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(63, 13);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(329, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbBooksResult
            // 
            this.lbBooksResult.FormattingEnabled = true;
            this.lbBooksResult.Location = new System.Drawing.Point(12, 114);
            this.lbBooksResult.Name = "lbBooksResult";
            this.lbBooksResult.Size = new System.Drawing.Size(392, 121);
            this.lbBooksResult.TabIndex = 4;
            this.lbBooksResult.SelectedIndexChanged += new System.EventHandler(this.lbBooksResult_SelectedIndexChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(12, 95);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(65, 13);
            this.lblBook.TabIndex = 5;
            this.lblBook.Text = "Select Book";
            // 
            // lblChapter
            // 
            this.lblChapter.AutoSize = true;
            this.lblChapter.Location = new System.Drawing.Point(12, 259);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(77, 13);
            this.lblChapter.TabIndex = 6;
            this.lblChapter.Text = "Select Chapter";
            // 
            // lbChaptersResult
            // 
            this.lbChaptersResult.FormattingEnabled = true;
            this.lbChaptersResult.Location = new System.Drawing.Point(12, 276);
            this.lbChaptersResult.Name = "lbChaptersResult";
            this.lbChaptersResult.Size = new System.Drawing.Size(392, 121);
            this.lbChaptersResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 416);
            this.Controls.Add(this.lbChaptersResult);
            this.Controls.Add(this.lblChapter);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lbBooksResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.txtBookName);
            this.Name = "Form1";
            this.Text = "Bindle - Like Kindle except it\'s trash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbBooksResult;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblChapter;
        private System.Windows.Forms.ListBox lbChaptersResult;
    }
}

