using AutoMapper;
using InventoryManager.Domain.Commands;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Domain.AutoMapper
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
