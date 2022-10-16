using FluentValidation;
using InventoryManager.API.Configurations;
using InventoryManager.API.Security;
using InventoryManager.Application.DTOs;
using InventoryManager.Application.Services;
using InventoryManager.Domain.Domain.Services;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using InventoryManager.Infrastructure;
using Microsoft.AspNetCore.Authentication;

namespace InventoryManager
{
    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IInventoryAppService, InventoryAppService>();
            builder.Services.AddScoped<IInventoryDomainService, InventoryDomainService>();
            builder.Services.AddSingleton<IRepository<InventoryItem>, InventoryManagerInMemoryRepository>();

            builder.Services.AddScoped<IValidator<InventoryItemDTO>, InventoryItemDTOValidator>();

            builder.Services.AddAutoMapperConfiguration();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // Basic authentication
            builder.Services.AddAuthentication("BasicAuthentication")
             .AddScheme<AuthenticationSchemeOptions, APIBasicAuthenticationHandler>
             ("BasicAuthentication", null);
            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}