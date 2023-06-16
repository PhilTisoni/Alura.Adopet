using Adopet.Models;
using Microsoft.EntityFrameworkCore;

namespace Adopet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tutor> Tutores { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}