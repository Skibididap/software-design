using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new BookstoreContext())
            {
                context.Database.EnsureCreated();
            }
        }
        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; } = null!;
            public virtual ICollection<Book> Books { get; set; } = null!;
        }
        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; } = null!;
            public virtual Author Author { get; set; } = null!;
        }
        public void AddAuthorWithBook(string authorName, string title)
        {
            using (var context = new BookstoreContext())
            {
                var authors = new Author { Name = authorName };
                var books = new Book { Title = title, Author = authors };
                context.Authors.Add(authors);
                context.Books.Add(books);
                context.SaveChanges();
            }
        }
        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthor = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                return booksWithAuthor;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddAuthorWithBook(txtAuthor.Text, txtTitle.Text);
            MessageBox.Show("Save Book");
        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }
        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBookAndAuthor(int.Parse(txtBookID.Text), txtTitle.Text, txtAuthor.Text);
            MessageBox.Show("Book and Author updated successfully");
        }
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookID == bookId);

                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully!");
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook(int.Parse(txtBookID.Text));
        }
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtAuthor.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                var results = SearchBooksByAuthor(query);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = results;
            }
        }
    }
}
