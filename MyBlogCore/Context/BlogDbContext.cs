using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyBlogCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogCore.Context
{
   public class BlogDbContext:DbContext
    {
        public BlogDbContext()
        {

        }

        public BlogDbContext (DbContextOptions<BlogDbContext> opt): base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KORKMAZ\\MSSQLSERVER04;Database=BlogDb;uid=sa;pwd=1");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Category> Category{ get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
