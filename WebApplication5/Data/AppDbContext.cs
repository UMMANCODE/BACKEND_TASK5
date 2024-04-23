using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.Data {
    public class AppDbContext : DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<BookTag>().HasKey(bt => new { bt.BookId, bt.TagId });
        }
    }
}
