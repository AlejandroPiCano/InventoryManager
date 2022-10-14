using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Entities;

namespace InventoryManager.Application
{
    internal static class InventoryItemConverter
    {
        /// <summary>
        /// Convert Inventory Item Entity To DTO
        /// </summary>
        /// <param name="inventoryItem"></param>
        /// <returns></returns>
        internal static InventoryItemDTO ConvertInventoryItemEntityToDTO(InventoryItem inventoryItem)
        {
            if (inventoryItem == null)
                return null;

            return new InventoryItemDTO() 
            {
                Id = inventoryItem.Id,
                Name = inventoryItem.Name,
                ExpirationDate = inventoryItem.ExpirationDate,
                Type = inventoryItem.Type
            };
        }

        /// <summary>
        /// Convert Inventory Item DTO to Entity
        /// </summary>
        /// <param name="inventoryItem"></param>
        /// <returns></returns>
        internal static InventoryItem ConvertInventoryDTOToEntitiy(InventoryItemDTO inventoryItemDTO, InventoryItem instance, bool isCreation = false)
        {
            if (inventoryItemDTO == null)
                return null;

            instance.Id = isCreation ? 0 : inventoryItemDTO.Id;
            instance.Name = inventoryItemDTO.Name;
            instance.ExpirationDate = inventoryItemDTO.ExpirationDate;
            instance.Type = inventoryItemDTO.Type;

            return instance;
        }
    }
}
