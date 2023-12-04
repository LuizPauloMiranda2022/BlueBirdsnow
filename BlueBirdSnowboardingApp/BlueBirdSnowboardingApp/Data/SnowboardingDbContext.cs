
using BlueBirdSnowboardingApp.models;
using Microsoft.EntityFrameworkCore;
namespace BlueBirdSnowboardingApp.Data;

public class SnowboardingDbContext:DbContext

{
    public DbSet<Snowboard> Snowboard { get; set; }
    public DbSet<Marca> Marca { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

        var stringConn = config.GetConnectionString("StringConn");

        optionsBuilder.UseSqlite(stringConn);

    }
}

