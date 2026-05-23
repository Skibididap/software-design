namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string? Title { get; set; }
            public string? Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Issue {IssueNumber}";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
            Book[] arrayBook =
               {new Book
                {
                 Title = "Calculus",
                 Author = "Aristotle"
                },
                new Magazine
                {
                    Title = "New York",
                    Author = "DeadPool",
                    IssueNumber = 16
                },
                new EBook
                {
                    Title = "Lord of The Mysteries",
                    Author = "CatleFish",
                    Published = "Yeng Press"
                },
                new TextBook 
                {
                    Title = "Math for Elementary",
                    Author = "Prof. Paran",
                    Subject = "Mathematics"
                },
                new AudioBook
                {
                    Title = "The Man and the Spider",
                    Author = "James Bond",
                    Duration = "1:43 m",
                    Narrator = "Vinz Clark"
                }
            };
            createArray(arrayBook);
        }
        public class EBook : Book
        {
            public string? Published { get; set; }
            public override string GetInfo()
            {
                return $"{Title}, Written by {Author} published by {Published}";
            }
        }
        private void createArray(Book[] arr)
        {
           lbArrayBooks.Items.Clear();
            foreach (Book b in arr)
            {
                lbArrayBooks.Items.Add(b.GetInfo());
            }
        }
        public class TextBook : Book
        {
            public string? Subject { get; set; }
            public override string GetInfo()
            {
                return $"Subject {Subject}, Title {Title} Written by {Author}";
            }
        }
        public class AudioBook : Book
        {
            public string? Duration { get; set; }
            public string? Narrator { get; set; }
            public override string GetInfo()
            {
                return $"{Title}, Written by {Author} Duration {Duration} Narrator {Narrator}";
            }
        }
    }
}
