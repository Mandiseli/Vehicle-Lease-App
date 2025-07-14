using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using VehicleLeaseApp.Models;

namespace VehicleLeaseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Configure MySQL using Pomelo.EntityFrameworkCore.MySql
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    "server=localhost;port=3306;database=vehicleleasingdb;uid=root;password=10/May/1989;",
                    new MySqlServerVersion(new Version(8, 0, 36)) // Adjust to your installed MySQL version
                )
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
