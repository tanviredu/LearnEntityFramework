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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=A:\\LearnEntityFramework\\ConsoleApp1\\database.db");
            
        }
    }
}