using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class EntityDbContext : DbContext
    {
        public DbSet<CategoryType> CategoryTypes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryType>();
            modelBuilder.Entity<Category>();
            modelBuilder.Entity<Book>();

            base.OnModelCreating(modelBuilder);
        }

        public EntityDbContext(DbContextOptions<EntityDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
