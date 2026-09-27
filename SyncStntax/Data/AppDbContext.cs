using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SyncStntax.Models;

namespace SyncStntax.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Models.Post> Posts { get; set; }
        public DbSet<Models.Comments> Comments { get; set; }
        public DbSet<Models.Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology" },
                new Category { Id = 2, Name = "Science" },
                new Category { Id = 3, Name = "Health" }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "The Future of AI",
                    Content = "Artificial Intelligence (AI) is rapidly evolving and has the potential to revolutionize various industries. From healthcare to finance, AI is being used to improve efficiency and decision-making.",
                    Author = "John Doe",
                    PublishedDate =new DateTime(2024, 6, 1),
                    CategoryId = 1
                },
                new Post
                {
                    Id = 2,
                    Title = "Exploring the Universe",
                    Content = "The universe is vast and full of mysteries. Scientists are constantly exploring space to understand its origins, structure, and the possibility of extraterrestrial life.",
                    Author = "Jane Smith",
                    PublishedDate = new DateTime(2024, 6, 2),
                    CategoryId = 2
                },
                new Post 
                {
                    Id = 3,
                    Title = "The Importance of Mental Health",
                    Content = "Mental health is a crucial aspect of overall well-being. It is important to raise awareness about mental health issues and provide support for those affected.",
                    Author = "Alice Johnson",
                    PublishedDate = new DateTime(2024, 6, 3),
                    CategoryId = 3
                }
            );
        }
        
    }
}