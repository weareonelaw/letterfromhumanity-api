using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace letterfromhumanityapi.Models
{ 
    public class ApiContext : DbContext
    {
        public DbSet<Sign> Sign { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Remove inline mysql string
            optionsBuilder.UseMySQL("server=localhost;database=letterfromhumanity;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sign>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.FirstName);
                entity.Property(e => e.LastName);
                //entity.Property(e => e.Email).IsRequired();
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.Country);
            });

        }
    }
}