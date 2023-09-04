
using SimpleShop.Application.Goods;
using SimpleShop.Application.Contracts.Goods;
using SimpleShop.Domain.Goods;
using SimpleShop.EntityFrameworkCore.Goods;
using SimpleShop.Application.Contracts.Categories;
using SimpleShop.Application.Categories;
using SimpleShop.Domain.Categories;
using SimpleShop.EntityFrameworkCore.Categories;

namespace SimpleShop.HttpApi.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // AppService
            builder.Services.AddScoped<IGoodAppService, GoodAppService>();
            builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();

            // Repository
            builder.Services.AddScoped<IGoodRepository, GoodRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            // Manager
            builder.Services.AddScoped<GoodManager>();
            builder.Services.AddScoped<CategoryManager>();

            // Adapter
            builder.Services.AddScoped<GoodAdapter>();
            builder.Services.AddScoped<CategoryAdapter>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}