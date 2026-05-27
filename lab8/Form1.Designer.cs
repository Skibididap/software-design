namespace lab8
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
            btnPrevPage = new Button();
            btnNextPage = new Button();
            btnSearchAuthor = new Button();
            label2 = new Label();
            txtAuthor = new TextBox();
            listBoxResults = new ListBox();
            BookDetails = new Label();
            txtBookDetails = new TextBox();
            label1 = new Label();
            btnFetchBook = new Button();
            txtISBN = new TextBox();
            SuspendLayout();
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(636, 369);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(94, 29);
            btnPrevPage.TabIndex = 21;
            btnPrevPage.Text = "Previous";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(636, 334);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 20;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(70, 321);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(94, 29);
            btnSearchAuthor.TabIndex = 19;
            btnSearchAuthor.Text = "Search";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 189);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 18;
            label2.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(70, 212);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 17;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(296, 75);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(269, 124);
            listBoxResults.TabIndex = 16;
            // 
            // BookDetails
            // 
            BookDetails.AutoSize = true;
            BookDetails.Location = new Point(70, 105);
            BookDetails.Name = "BookDetails";
            BookDetails.Size = new Size(89, 20);
            BookDetails.TabIndex = 15;
            BookDetails.Text = "BookDetails";
            // 
            // txtBookDetails
            // 
            txtBookDetails.Location = new Point(70, 128);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.Size = new Size(125, 48);
            txtBookDetails.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 52);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 13;
            label1.Text = "ISBN";
            // 
            // btnFetchBook
            // 
            btnFetchBook.Location = new Point(70, 356);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(94, 29);
            btnFetchBook.TabIndex = 12;
            btnFetchBook.Text = "Fetch";
            btnFetchBook.UseVisualStyleBackColor = true;
            btnFetchBook.Click += btnFetchBook_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(70, 75);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(125, 27);
            txtISBN.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrevPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnSearchAuthor);
            Controls.Add(label2);
            Controls.Add(txtAuthor);
            Controls.Add(listBoxResults);
            Controls.Add(BookDetails);
            Controls.Add(txtBookDetails);
            Controls.Add(label1);
            Controls.Add(btnFetchBook);
            Controls.Add(txtISBN);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrevPage;
        private Button btnNextPage;
        private Button btnSearchAuthor;
        private Label label2;
        private TextBox txtAuthor;
        private ListBox listBoxResults;
        private Label BookDetails;
        private TextBox txtBookDetails;
        private Label label1;
        private Button btnFetchBook;
        private TextBox txtISBN;
    }
}
