using AutoMapper;
using InventoryManager.Application.DTOs;
using InventoryManager.Application.Commands;

namespace InventoryManager.Application.AutoMapper
{
    public class InventoryItemDTOToUpdateInventoryCommand : Profile
    {
        public InventoryItemDTOToUpdateInventoryCommand()
        {
            CreateMap<InventoryItemDTO, UpdateInventoryCommand>();
        }
    }
}
