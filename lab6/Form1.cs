using lab5;
using Microsoft.EntityFrameworkCore;
using static lab5.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async Task<List<string>> GetBooksAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {

                progress?.Report(20);
                await Task.Delay(400);

                progress?.Report(50);
                var books = await context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                    .ToListAsync();

                await Task.Delay(400);
                progress?.Report(100);

                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value => progressBar1.Value = value);

            var books = await GetBooksAsync(progress);
            listBoxBooks.DataSource = books;
        }
        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);


                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var author = txtAuthor.Text;
            var title = txtTitle.Text;
            await SaveBookAsync(author, title);
            MessageBox.Show("Book and Author saved successfully");
        }
        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books
                    .Include(b => b.Author)
                    .FirstOrDefaultAsync(b => b.BookID == bookId);

                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    await context.SaveChangesAsync();
                }
            }
        }
        public async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FirstOrDefaultAsync(b => b.BookID == bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }
        public async Task<List<string>> SearchBooksAsync(string titleQuery)
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
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtTitle.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                var results = await SearchBooksAsync(query);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = results;
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            await UpdateBookAsync(int.Parse(txtBookID.Text), txtTitle.Text, txtAuthor.Text);
            MessageBox.Show("Book and Author update successfully");
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            await DeleteBookAsync(int.Parse(txtBookID.Text));
            MessageBox.Show("Book and Author delete successfully");
        }
    }
}
