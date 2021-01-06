using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DrOffice.Models
{
  public class DrOfficeContextFactory : IDesignTimeDbContextFactory<DrOfficeContext>
  {

    DrOfficeContext IDesignTimeDbContextFactory<DrOfficeContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<DrOfficeContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new DrOfficeContext(builder.Options);
    }
  }
}