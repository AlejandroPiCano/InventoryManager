using AutoMapper;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Commands;

namespace InventoryManager.Domain.AutoMapper
{
    public class CreateInventoryCommandToInventoryItem : Profile
    {
        public CreateInventoryCommandToInventoryItem()
        {
            CreateMap<CreateInventoryCommand, InventoryItem>();
        }
    }
}
