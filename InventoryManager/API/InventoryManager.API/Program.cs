using FluentValidation;
using InventoryManager.API.Configurations;
using InventoryManager.API.Security;
using InventoryManager.Application.DTOs;
using InventoryManager.Application.Services;
using InventoryManager.Domain.Services;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using InventoryManager.Infrastructure;
using Microsoft.AspNetCore.Authentication;
using MediatR;
using MassTransit;
using InventoryManager.Domain.Events;

namespace InventoryManager
{
    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        static bool? _isRunningInContainer;

        static bool IsRunningInContainer =>
    _isRunningInContainer ??= bool.TryParse(Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER"), out var inContainer) && inContainer;

        /// <summary>
        /// The Main method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //Use this FakeEventManager and comment the MassTransit's region for desactivate RabbitMq in order to use Docker without Rabbitmq.
            //builder.Services.AddScoped<ICustomEventManager, FakeEventManager>();

            //Use this CustomEventManager and uncomment the MassTransit's region for activate RabbitMq in order to use Docker without Rabbitmq.
            builder.Services.AddScoped<ICustomEventManager, CustomEventManager>();
            builder.Services.AddScoped<IInventoryAppService, InventoryCQRSAppService>();
            builder.Services.AddScoped<IInventoryDomainService, InventoryDomainService>();
            builder.Services.AddSingleton<IRepository<InventoryItem>, InventoryManagerInMemoryRepository>();

            // Adding MediatR for Domain Events and Notifications
            builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped<IValidator<InventoryItemDTO>, InventoryItemDTOValidator>();

            builder.Services.AddAutoMapperConfiguration();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options => options.AddPolicy("EnableCORS", builder =>
            {
                builder.AllowAnyMethod()
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();

            }));

            //// Comment this region for desactivate RabbitMq
            #region MassTransit
          
            builder.Services.AddMassTransit(x =>
            {
               
                x.UsingRabbitMq((context, cfg) =>
                {
                    if (IsRunningInContainer)
                    {
                        cfg.AutoStart = true;
                        cfg.Host("rabbitmq");
                    }
                    else
                    {
                        cfg.Host("localhost", "/", h =>
                        {
                            h.Username(builder.Configuration["ServicesBus:UserName"]);
                            h.Password(builder.Configuration["ServicesBus:Password"]);
                        });
                    }

                    cfg.ConfigureEndpoints(context);
                });
            });

            builder.Services.AddMassTransitHostedService(true);
            #endregion

            // Basic authentication
            builder.Services.AddAuthentication("BasicAuthentication")
             .AddScheme<AuthenticationSchemeOptions, APIBasicAuthenticationHandler>
             ("BasicAuthentication", null);
            builder.Services.AddAuthorization();

            var app = builder.Build();
            app.UseCors("EnableCORS");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}