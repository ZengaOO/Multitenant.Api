//using Infrastructure.Persistence;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
////builder.Services.AddDbContext<ApplicationDbContext>(
////       options => options.UseSqlServer("name=ConnectionStrings:ConnectionString"));


//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();



//using Microsoft.EntityFrameworkCore;

//public class Program
//{
//    public static void Main(string[] args)
//        => CreateHostBuilder(args).Build().Run();

//    // EF Core uses this method at design time to access the DbContext
//    public static IHostBuilder CreateHostBuilder(string[] args)
//        => Host.CreateDefaultBuilder(args)
//            .ConfigureWebHostDefaults(
//                webBuilder => webBuilder.UseStartup<Startup>());
//}

//public class Startup
//{
//    public void ConfigureServices(IServiceCollection services)
//    {
//        IServiceCollection serviceCollection = services.AddDbContext<ApplicationDbContext>();
//    }

//    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//    {
//    }
//}

//public class ApplicationDbContext : DbContext
//{
//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//        : base(options)
//    {
//    }
//}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Multitenant1.Api;

namespace Multitenant.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}