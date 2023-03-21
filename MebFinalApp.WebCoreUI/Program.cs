using MebFinalApp.Business.Abstract;
using MebFinalApp.Business.Concrete;
using MebFinalApp.Data.Abstract;
using MebFinalApp.Data.Concrete.Entityframework.repository;

namespace MebFinalApp.WebCoreUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSingleton<IPersonelBs, PersonelBs>();
            builder.Services.AddSingleton<IPersonelRepository, EfPersonelRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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