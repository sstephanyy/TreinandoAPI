using Microsoft.EntityFrameworkCore;
using TreinandoAPI.Model;

namespace TreinandoAPI.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
               );


    }
}
