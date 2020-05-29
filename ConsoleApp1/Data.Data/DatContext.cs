using System;
using Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class DataContext : DbContext
    {
        // adding dbsets
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=A:\\LearnEntityFramework\\ConsoleApp1\\database.db");
            
        }
        
        
        /// <summary>
        /// here we will confidure all the relationship
        /// oneto many and one to one
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(c => c.Books)
                .WithOne(a => a.Author);

        // you an do the reverse way too    
            
            // this is the many to many relationship
            modelBuilder.Entity<BookCategory>().HasKey(s => new {s.BookId, s.CategoryId});
        }
        
        
    }
}