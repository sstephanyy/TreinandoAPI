using Microsoft.EntityFrameworkCore;
using TreinandoAPI.Model;

namespace TreinandoAPI.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=  ec2-35-169-88-97.compute-1.amazonaws.com;" +
                "Port=5432;Database=dev_stephany;" +
                "User Id= stephany;" +
                "Password=TKFBF0OdWFoYgqr6hy45;");


    }
}
