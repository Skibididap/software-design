using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab5
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; } 
        public DbSet<Book> Books { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=newBookstoreDB;Trusted_Connection=True;");
        }
    }
}
