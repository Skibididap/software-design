using lab5;
using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int pageSize = 10;
        private int currentPage = 1;
        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                    .ToListAsync();
                return books;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }
        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    await context.SaveChangesAsync();
                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthor.Text;
            var bookTitle = txtTitle.Text;
            await SaveBookWithHandlingAsync(bookTitle, authorName);
        }
        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Book List"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully!");
            }
        }
        public async Task<List<string>> SearchBooksWithHandlingAsync(string titleQuery)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    return await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(titleQuery))
                        .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                        .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtTitle.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                var results = await SearchBooksWithHandlingAsync(query);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = results;
            }
        }
        public async Task ImportBooksAsync(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    using (var context = new BookstoreContext())
                    {
                        while ((line = await reader.ReadLineAsync()) != null)
                        {

                            if (string.IsNullOrWhiteSpace(line)) continue;


                            var parts = line.Split(',');
                            if (parts.Length >= 2)
                            {
                                string title = parts[0].Trim();
                                string authorName = parts[1].Trim();

                                var author = new Author { Name = authorName };
                                var book = new Book { Title = title, Author = author };

                                context.Authors.Add(author);
                                context.Books.Add(book);
                            }
                        }
                        await context.SaveChangesAsync();
                    }
                }
                MessageBox.Show("Book records imported and saved to database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Import failed: {ex.Message}", "File Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnImportBook_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await ImportBooksAsync(openFileDialog.FileName);
                }
            }
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }
    }
}

