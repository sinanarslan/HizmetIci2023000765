using MebFinalApp.Business.Abstract;
using MebFinalApp.Business.Concrete;
using MebFinalApp.Data.Abstract;
using MebFinalApp.Data.Concrete.Entityframework.repository;

namespace MebFinalApp.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddSingleton<IPersonelBs, PersonelBs>();
            builder.Services.AddSingleton<IPersonelRepository, EfPersonelRepository>();

            builder.Services.AddSingleton<IUserBs, UserBs>();
            builder.Services.AddSingleton<IUserRepository, EfUserRespoitory>();


            builder.Services.AddSingleton<IUrunBs, UrunBs>();
            builder.Services.AddSingleton<IUrunRepository, EfUrunRepository>();


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseCors();


            app.MapControllers();

            app.Run();
        }
    }
}