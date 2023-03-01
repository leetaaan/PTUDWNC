using Microsoft.EntityFrameworkCore;
using TatBlog.Core.Entities;
using TatBlog.Data.Mappings;
namespace TatBlog.Data.Contextsc
{
    internal class BlogDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-CC408KD;Database=TagBlog;Trusted_Connection=True;
MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryMap).Assembly);
        }
    }
}