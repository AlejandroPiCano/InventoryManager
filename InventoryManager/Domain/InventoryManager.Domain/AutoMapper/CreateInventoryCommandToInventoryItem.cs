using AutoMapper;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Commands;

namespace InventoryManager.Domain.AutoMapper
{
    /// <summary>
    /// The CreateInventoryCommandToInventoryItem class
    /// </summary>
    public class CreateInventoryCommandToInventoryItem : Profile
    {
        /// <summary>
        /// The CreateInventoryCommandToInventoryItem constructor
        /// </summary>
        public CreateInventoryCommandToInventoryItem()
        {
            CreateMap<CreateInventoryCommand, InventoryItem>();
        }
    }
}
