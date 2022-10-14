using InventoryManager.Application.Services;
using InventoryManager.Domain.Domain.Services;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using InventoryManager.Infrastructure;
using InventoryManager.Infrastructure.Entities;

namespace InventoryManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IInventoryListService, InventoryListService>();
            builder.Services.AddScoped<IInventoryDomainService, InventoryDomainService>();
            builder.Services.AddSingleton<IRepository<InventoryItem>, InventoryManagerInMemoryRepository>();

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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}