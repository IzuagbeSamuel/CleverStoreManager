using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerContext : IdentityDbContext<CleverStoreManagerUser>
   {
      public DbSet<CleverStoreManagerBusiness> CleverStoreManagerBusinesses { get; set; }

      public DbSet<CleverStoreManagerPayment> CleverStoreManagerPayments { get; set; }


      public CleverStoreManagerContext(DbContextOptions options) : base(options) { }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseLazyLoadingProxies();
      }
   } 
}