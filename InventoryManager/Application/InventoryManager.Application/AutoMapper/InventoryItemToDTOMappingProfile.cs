using AutoMapper;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Application.AutoMapper
{
    public class InventoryItemToDTOMappingProfile : Profile
    {
        public InventoryItemToDTOMappingProfile()
        {
            CreateMap<InventoryItem, InventoryItemDTO>();
        }
    }
}
