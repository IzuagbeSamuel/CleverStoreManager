using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CleverStoreManager.Models
{
   public class DesignTimeContextFactory : IDesignTimeDbContextFactory<CleverStoreManagerContext>
   {
      CleverStoreManagerContext IDesignTimeDbContextFactory<CleverStoreManagerContext>.CreateDbContext(string[] args)
      {
         IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

         var builder = new DbContextOptionsBuilder<CleverStoreManagerContext>();

         builder.UseMySql(configuration["ConnectionStrings:CleverStoreManagerConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:CleverStoreManagerConnection"]));

         return new CleverStoreManagerContext(builder.Options);
      }
   }
}