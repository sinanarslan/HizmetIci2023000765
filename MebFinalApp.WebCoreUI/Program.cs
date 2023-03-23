using FluentValidation;
using FluentValidation.AspNetCore;
using MebFinalApp.Business.Abstract;
using MebFinalApp.Business.Concrete;
using MebFinalApp.Business.ValidationRules;
using MebFinalApp.Data.Abstract;
using MebFinalApp.Data.Concrete.Entityframework.repository;
using MebFinalApp.Model.ViewModel.Admin;
using MebFinalApp.WebCoreUI.Areas.Admin.Filter;
using System.Reflection;

namespace MebFinalApp.WebCoreUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddFluentValidation();
            builder.Services.AddSession();

            builder.Services.AddSingleton<IPersonelBs, PersonelBs>();
            builder.Services.AddSingleton<IPersonelRepository, EfPersonelRepository>();

            builder.Services.AddSingleton<IUserBs, UserBs>();
            builder.Services.AddSingleton<IUserRepository, EfUserRespoitory>();
            builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            builder.Services.AddSingleton<ISessionManager, SessionManager>();

            builder.Services.AddSingleton<IValidator<UserLoginViewModel>, UserLoginViewModelValidator>();
         



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );


                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            });



            app.Run();
        }
    }
}