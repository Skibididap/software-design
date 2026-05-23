namespace lab3
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
            btnShowInfo = new Button();
            lbArrayBooks = new ListBox();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.FlatStyle = FlatStyle.Flat;
            btnShowInfo.Location = new Point(24, 49);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(94, 29);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // lbArrayBooks
            // 
            lbArrayBooks.FormattingEnabled = true;
            lbArrayBooks.Location = new Point(191, 49);
            lbArrayBooks.Name = "lbArrayBooks";
            lbArrayBooks.Size = new Size(582, 264);
            lbArrayBooks.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 358);
            Controls.Add(lbArrayBooks);
            Controls.Add(btnShowInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox lbArrayBooks;
    }
}
