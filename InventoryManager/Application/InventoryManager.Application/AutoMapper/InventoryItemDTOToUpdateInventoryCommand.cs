using AutoMapper;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Commands;

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
