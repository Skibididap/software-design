namespace lab5
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
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            txtAuthor = new TextBox();
            btnShowBook = new Button();
            label4 = new Label();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(206, 96);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(570, 204);
            listBoxBooks.TabIndex = 11;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(35, 236);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 10;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 9;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 193);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(151, 27);
            txtTitle.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(12, 139);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(151, 27);
            txtAuthor.TabIndex = 6;
            // 
            // btnShowBook
            // 
            btnShowBook.Location = new Point(206, 306);
            btnShowBook.Name = "btnShowBook";
            btnShowBook.Size = new Size(94, 29);
            btnShowBook.TabIndex = 12;
            btnShowBook.Text = "Show";
            btnShowBook.UseVisualStyleBackColor = true;
            btnShowBook.Click += btnShowBook_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 14;
            label4.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(12, 85);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(151, 27);
            txtBookID.TabIndex = 13;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(35, 271);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 29);
            btnUpdateBook.TabIndex = 15;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(35, 306);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(94, 29);
            btnDeleteBook.TabIndex = 16;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(35, 341);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            Controls.Add(btnShowBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtAuthor;
        private Button btnShowBook;
        private Label label4;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Button btnSearch;
    }
}
