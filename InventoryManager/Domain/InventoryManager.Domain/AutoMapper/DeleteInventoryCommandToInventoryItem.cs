using AutoMapper;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Commands;

namespace InventoryManager.Domain.AutoMapper
{
    /// <summary>
    /// The DeleteInventoryCommandToInventoryItem class
    /// </summary>
    public class DeleteInventoryCommandToInventoryItem : Profile
    {
        /// <summary>
        /// The DeleteInventoryCommandToInventoryItem constructor
        /// </summary>
        public DeleteInventoryCommandToInventoryItem()
        {
            CreateMap<DeleteByNameInventoryCommand, InventoryItem>();
        }
    }
}
