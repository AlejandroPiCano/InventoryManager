using InventoryManager.Application.AutoMapper;

namespace InventoryManager.API.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(InventoryItemDTOToEntityMappingProfile), typeof(InventoryItemToDTOMappingProfile));
        }
    }
}