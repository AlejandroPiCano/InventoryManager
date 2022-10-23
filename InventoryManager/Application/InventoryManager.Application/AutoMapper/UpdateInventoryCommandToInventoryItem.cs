using AutoMapper;
using InventoryManager.Application.Commands;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Application.AutoMapper
{
    /// <summary>
    /// The UpdateInventoryCommandToInventoryItem class
    /// </summary>
    public class UpdateInventoryCommandToInventoryItem : Profile
    {
        /// <summary>
        /// The UpdateInventoryCommandToInventoryItem constructor.
        /// </summary>
        public UpdateInventoryCommandToInventoryItem()
        {
            CreateMap<UpdateInventoryCommand, InventoryItem>();
        }
    }
}
