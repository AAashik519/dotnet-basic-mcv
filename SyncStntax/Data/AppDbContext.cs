using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        
        
    }
}