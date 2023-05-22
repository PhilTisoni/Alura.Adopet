using Adopet.Models;
using Microsoft.EntityFrameworkCore;

namespace Adopet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Visitante> Visitantes { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}