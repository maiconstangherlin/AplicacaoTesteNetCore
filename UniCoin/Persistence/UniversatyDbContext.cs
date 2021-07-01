using Microsoft.EntityFrameworkCore;
using UniCoin.Models;

namespace UniversatyCoin.Persistence
{
    public class UniversatyDbContext : DbContext
    {
        public UniversatyDbContext(DbContextOptions<UniversatyDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Students");
                entity.HasKey(field => field.Id);

                entity.Property(field => field.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

        }

    }
}
