using FirstAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options) :base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Books>().HasData(
                 new Books
                 {
                     Book_id = 1,
                     Title = "To Kill a Mockingbird",
                     Author = "Harper Lee",
                     Public_year = 1960
                 },
            new Books
            {
                Book_id = 2,
                Title = "1984",
                Author = "George Orwell",
                Public_year = 1949
            },
            new Books
            {
                Book_id = 3,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Public_year = 1813
            },
            new Books
            {
                Book_id = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Public_year = 1813
            },
            new Books
            {
                Book_id = 5,
                Title = "The Hobbit",
                Author = "J.R.R Tolkien",
                Public_year = 1937
            }

                );
        }
        
            
        

        public DbSet<Books> Books { get; set; }
    }
}
