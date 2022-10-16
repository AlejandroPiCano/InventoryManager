using AutoMapper;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Commands;

namespace InventoryManager.Domain.AutoMapper
{
    public class DeleteInventoryCommandToInventoryItem : Profile
    {
        public DeleteInventoryCommandToInventoryItem()
        {
            CreateMap<DeleteByNameInventoryCommand, InventoryItem>();
        }
    }
}
