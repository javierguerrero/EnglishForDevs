using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Dialogue> Dialogues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category() { Id = 1, Name = "Software Requirements" },
                    new Category() { Id = 2, Name = "Software Design" },
                    new Category() { Id = 3, Name = "Software Construction" }
                );

            modelBuilder.Entity<Topic>()
                .HasData(
                    new Topic() { Id = 1, Name = "DIP and decoupling", CategoryId = 2},
                    new Topic() { Id = 2, Name = "MVC architecture pattern", CategoryId = 2 },
                    new Topic() { Id = 3, Name = "Dependency Injection", CategoryId = 2 }
                );
        }
    }
}