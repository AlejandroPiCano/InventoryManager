using AutoMapper;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Application.AutoMapper
{
    public class InventoryItemDTOToEntityMappingProfile : Profile
    {
        public InventoryItemDTOToEntityMappingProfile()
        {
            CreateMap<InventoryItemDTO, InventoryItem>();
        }
    }
}
