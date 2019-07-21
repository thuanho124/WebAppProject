using LibraryManagementSys.Models;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSys.Data;

namespace LibraryManagementSys.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<RentedBook> RentedBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Librarian>().ToTable("Librarian");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<RentedBook>().ToTable("RentedBook");
        }
    }
}