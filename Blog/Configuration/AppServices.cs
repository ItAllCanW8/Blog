using Blog.BusinessManagers;
using Blog.BusinessManagers.Interfaces;
using Blog.Data;
using Blog.Data.Models;
using Blog.Service;
using Blog.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Configuration
{
    public static class AppServices
    {
        public static void AddDefaultServices(this IServiceCollection serviceCollection, IConfiguration configuration) {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(
                       configuration.GetConnectionString("DefaultConnection")));
            serviceCollection.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            serviceCollection.AddControllersWithViews().AddRazorRuntimeCompilation();
            serviceCollection.AddRazorPages();
        }

        public static void AddCustomServices(this IServiceCollection serviceCollection)
        { 
            serviceCollection.AddScoped<IBlogBusinessManager, BlogBusinessManager>();
            serviceCollection.AddScoped<IBlogService, BlogService>();
        }

    }
}
