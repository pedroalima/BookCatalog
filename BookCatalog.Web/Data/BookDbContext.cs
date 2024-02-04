using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookCatalog.Web.Data
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
