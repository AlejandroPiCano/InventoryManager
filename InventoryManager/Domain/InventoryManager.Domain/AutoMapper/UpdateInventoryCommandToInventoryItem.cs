using AutoMapper;
using InventoryManager.Domain.Commands;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Domain.AutoMapper
{
    public class UpdateInventoryCommandToInventoryItem : Profile
    {
        public UpdateInventoryCommandToInventoryItem()
        {
            CreateMap<UpdateInventoryCommand, InventoryItem>();
        }
    }
}
