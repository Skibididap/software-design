namespace lab7
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPageNumber = new Label();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            listBoxBooks = new ListBox();
            btnSearch = new Button();
            btnImportBook = new Button();
            btnExportBooks = new Button();
            label4 = new Label();
            txtBookID = new TextBox();
            btnAddBook = new Button();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            txtAuthor = new TextBox();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(12, 9);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(50, 20);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "label1";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(12, 409);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(108, 29);
            btnPreviousPage.TabIndex = 1;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(694, 409);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(299, 46);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(454, 284);
            listBoxBooks.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(36, 338);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnImportBook
            // 
            btnImportBook.Location = new Point(36, 303);
            btnImportBook.Name = "btnImportBook";
            btnImportBook.Size = new Size(94, 29);
            btnImportBook.TabIndex = 33;
            btnImportBook.Text = "Import";
            btnImportBook.UseVisualStyleBackColor = true;
            btnImportBook.Click += btnImportBook_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(36, 268);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(94, 29);
            btnExportBooks.TabIndex = 32;
            btnExportBooks.Text = "Export";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 46);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 31;
            label4.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(12, 70);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(151, 27);
            txtBookID.TabIndex = 30;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(36, 233);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 29;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 28;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 178);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(151, 27);
            txtTitle.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 26;
            label1.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(12, 124);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(151, 27);
            txtAuthor.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnImportBook);
            Controls.Add(btnExportBooks);
            Controls.Add(label4);
            Controls.Add(txtBookID);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Controls.Add(listBoxBooks);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private ListBox listBoxBooks;
        private Button btnSearch;
        private Button btnImportBook;
        private Button btnExportBooks;
        private Label label4;
        private TextBox txtBookID;
        private Button btnAddBook;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtAuthor;
    }
}
