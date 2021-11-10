using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using CleverStoreManager.Models;


namespace CleverStoreManager
{
   public class Startup
   {
		private readonly IConfiguration _config;
      public  Startup(IWebHostEnvironment env, IConfiguration config)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json");
			Configuration = builder.Build();

			_config = config;
		}

		public IConfigurationRoot Configuration { get; set; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddDbContext<CleverStoreManagerContext>(options => options.UseMySql(Configuration["ConnectionStrings:CleverStoreManagerConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:CleverStoreManagerConnection"])));
			services.AddIdentity<CleverStoreManagerUser, IdentityRole>()
				.AddEntityFrameworkStores<CleverStoreManagerContext>()
				.AddDefaultTokenProviders();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseDeveloperExceptionPage();

			app.UseAuthentication();

			app.UseRouting();
		
			app.UseAuthorization();

			app.UseHttpsRedirection();

			app.UseEndpoints(routes =>
			{
				routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
				routes.MapRazorPages();
			});
			
			app.UseStaticFiles();
		}
   }
}
