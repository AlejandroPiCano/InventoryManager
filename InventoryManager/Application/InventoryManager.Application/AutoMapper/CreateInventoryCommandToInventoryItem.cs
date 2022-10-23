using AutoMapper;
using InventoryManager.Application.Commands;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Application.AutoMapper
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
