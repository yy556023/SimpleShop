using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SimpleShop.EntityFrameworkCore.EntityFrameworkCore
{
    public class SimpleShopDbContextFactory : IDesignTimeDbContextFactory<SimpleShopDbContext>
    {
        public SimpleShopDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SimpleShopDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SimpleShopDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SimpleShop.HttpApi.Host/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
