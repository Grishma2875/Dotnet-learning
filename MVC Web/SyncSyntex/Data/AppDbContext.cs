using Microsoft.EntityFrameworkCore;
using SyncSyntex.Models;

namespace SyncSyntex.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology" },
                new Category { Id = 2, Name = "Health" },
                new Category { Id = 3, Name = "Lifestyle" }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    id = 1,
                    Title = "First Post",
                    Content = "Content of the first post.",
                    Author = "John Doe",
                    PublishedDate = DateTime.Now,
                    CategoryId = 1,
                    FeatureImagePath = "images/first-post.jpg",
                },
                 new Post
                 {
                     id = 2,
                     Title = "Second Post",
                     Content = "Content of the second post.",
                     Author = "John Doe",
                     PublishedDate = DateTime.Now,
                     CategoryId = 2,
                     FeatureImagePath = "images/first-post.jpg",
                 },
                  new Post
                  {
                      id = 3,
                      Title = "Third Post",
                      Content = "Content of the third post.",
                      Author = "John Doe",
                      PublishedDate = DateTime.Now,
                      CategoryId = 3,
                      FeatureImagePath = "images/first-post.jpg",
                  }



                );
        }
    }
}
