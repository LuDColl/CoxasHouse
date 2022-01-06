using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class CoxaDbContext : DbContext
    {
        public CoxaDbContext() { }

        public CoxaDbContext(DbContextOptions<CoxaDbContext> opcoes) :base(opcoes) { }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
