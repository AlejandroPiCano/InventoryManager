using AutoMapper;
using InventoryManager.Application.Commands;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Application.AutoMapper
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
