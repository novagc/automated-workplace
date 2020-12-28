using System;
using System.Diagnostics;
using AW.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AW.Data.DataBase
{
    sealed class PostgresContext: DbContext
    {
        private readonly Config _config;

        public DbSet<Order> Orders { get; set; }
        public DbSet<Worker> Workers { get; set; }

        public PostgresContext(Config config)
        {
            _config = config;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(String.Join(";", new []
            {
                $"Host={_config.Host}",
                $"Port={_config.Port}",
                $"Database={_config.DataBaseName}",
                $"Username={_config.Login}",
                $"Password={_config.Password}"
            }));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>()
                .HasIndex(w => w.Login)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
