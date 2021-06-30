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

    }
}
