using AutoMapper;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Commands;

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
