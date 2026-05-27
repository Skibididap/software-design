using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace lab8
{
    public partial class Form1 : Form
    {
        private int currentStartIndex = 0;
        private const int maxResultsPerPage = 10;

        public Form1()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            InitializeComponent();
        }

        public async Task<string> GetBookInfoFromAPIAsync(string isbn)
        {
            string apiUrl = $"https://openlibrary.org/api/books?bibkeys=ISBN:{isbn}&format=json&jscmd=data";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(15);
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                    string response = await client.GetStringAsync(apiUrl);
                    JObject jsonResponse = JObject.Parse(response);

                    string bookKey = $"ISBN:{isbn}";
                    if (jsonResponse[bookKey] != null)
                    {
                        var bookData = jsonResponse[bookKey];

                        string title = bookData["title"]?.ToString() ?? "Unknown Title";

                        var authorsArray = bookData["authors"];
                        string authors = authorsArray != null
                            ? string.Join(", ", authorsArray.Select(a => a["name"]?.ToString()))
                            : "Unknown Author";

                        string description = bookData["notes"]?.ToString() ??
                                             bookData["subtitle"]?.ToString() ??
                                             "No description available in open database.";

                        return $"Title: {title}\r\nAuthors: {authors}\r\n\r\nDescription: {description}";
                    }

                    return "No book found matching that ISBN in the database.";
                }
            }
            catch (HttpRequestException ex)
            {
                return $"Network Error Details: {ex.Message}";
            }
            catch (TaskCanceledException)
            {
                return "Error: The connection timed out.";
            }
            catch (Exception ex)
            {
                return $"Unexpected Error: {ex.Message}";
            }
        }

        private async void btnFetchBook_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Please enter an ISBN first.");
                return;
            }

            txtBookDetails.Text = "Loading book details from open registry...";
            string bookInfo = await GetBookInfoFromAPIAsync(isbn);

            txtBookDetails.Text = "Done!";

            listBoxResults.DataSource = null;
            listBoxResults.Items.Clear();

            string[] lines = bookInfo.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                listBoxResults.Items.Add(line);
            }
        }

        public async Task<List<string>> SearchBooksByAuthorAsync(string authorName, int startIndex)
        {

            int pageNumber = (startIndex / maxResultsPerPage) + 1;
            string apiUrl = $"https://openlibrary.org/search.json?author={Uri.EscapeDataString(authorName)}&page={pageNumber}&limit={maxResultsPerPage}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(15);
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                    string response = await client.GetStringAsync(apiUrl);
                    JObject jsonResponse = JObject.Parse(response);
                    List<string> titlesFound = new List<string>();

                    if (jsonResponse["docs"] != null && jsonResponse["docs"].HasValues)
                    {
                        foreach (var doc in jsonResponse["docs"])
                        {
                            string title = doc["title"]?.ToString() ?? "Untitled Book";
                            titlesFound.Add(title);
                        }
                    }
                    else
                    {
                        titlesFound.Add("No books found on this page.");
                    }

                    return titlesFound;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}");
                return new List<string>() { "Error pulling data entries." };
            }
        }

        private async Task LoadAuthorPageAsync()
        {
            string author = txtAuthor.Text.Trim();
            if (string.IsNullOrWhiteSpace(author)) return;

            var books = await SearchBooksByAuthorAsync(author, currentStartIndex);
            listBoxResults.DataSource = null;
            listBoxResults.DataSource = books;
        }

        private async void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please type an author name.");
                return;
            }
            currentStartIndex = 0;
            await LoadAuthorPageAsync();
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentStartIndex += maxResultsPerPage;
            await LoadAuthorPageAsync();
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentStartIndex >= maxResultsPerPage)
            {
                currentStartIndex -= maxResultsPerPage;
                await LoadAuthorPageAsync();
            }
        }
    }
}