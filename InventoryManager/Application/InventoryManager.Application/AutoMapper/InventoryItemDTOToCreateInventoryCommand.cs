using AutoMapper;
using InventoryManager.Application.DTOs;
using InventoryManager.Application.Commands;

namespace InventoryManager.Application.AutoMapper
{
    public class InventoryItemDTOToCreateInventoryCommand : Profile
    {
        public InventoryItemDTOToCreateInventoryCommand()
        {
            CreateMap<InventoryItemDTO, CreateInventoryCommand>();
        }
    }
}
