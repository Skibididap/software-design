namespace lab6
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            txtAuthor = new TextBox();
            btnAddBook = new Button();
            progressBar1 = new ProgressBar();
            btnSearch = new Button();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            label4 = new Label();
            txtBookID = new TextBox();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(244, 152);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(94, 29);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(244, 42);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(448, 104);
            listBoxBooks.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 13;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 173);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(151, 27);
            txtTitle.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 11;
            label1.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(12, 119);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(151, 27);
            txtAuthor.TabIndex = 10;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(36, 228);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 14;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(244, 187);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(448, 29);
            progressBar1.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(36, 333);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(36, 298);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(94, 29);
            btnDeleteBook.TabIndex = 23;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(36, 263);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 29);
            btnUpdateBook.TabIndex = 22;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 41);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 21;
            label4.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(12, 65);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(151, 27);
            txtBookID.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(label4);
            Controls.Add(txtBookID);
            Controls.Add(progressBar1);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtAuthor;
        private Button btnAddBook;
        private ProgressBar progressBar1;
        private Button btnSearch;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Label label4;
        private TextBox txtBookID;
    }
}
