using EComAPI.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EComAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EComDbContext>
{
    public EComDbContext CreateDbContext(string[] args)
    {
     

        DbContextOptionsBuilder<EComDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configurations.ConnectionString);

        return new(dbContextOptionsBuilder.Options);
    }
}
