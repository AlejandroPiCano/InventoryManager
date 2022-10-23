using InventoryManager.Application.AutoMapper;

namespace InventoryManager.API.Configurations
{
    /// <summary>
    /// AutoMapperConfig class.
    /// </summary>
    public static class AutoMapperConfig
    {
        /// <summary>
        /// AddAutoMapperConfiguration method.
        /// </summary>
        /// <param name="services"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(
                typeof(InventoryItemDTOToEntityMappingProfile),
                typeof(InventoryItemToDTOMappingProfile),
                typeof(InventoryItemDTOToCreateInventoryCommand),
                typeof(InventoryItemDTOToUpdateInventoryCommand),                                
                typeof(CreateInventoryCommandToInventoryItem),
                typeof(UpdateInventoryCommandToInventoryItem)
                );
        }
    }
}