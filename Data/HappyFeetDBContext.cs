using HappyFeetAppWeb.Models;
using Microsoft.EntityFrameworkCore;
namespace HappyFeetAppWeb.Data;

public class HappyFeetDBContext : DbContext
{
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var stringConec = config.GetConnectionString("StringConec");

        optionsBuilder.UseSqlServer(stringConec);

    }
}
