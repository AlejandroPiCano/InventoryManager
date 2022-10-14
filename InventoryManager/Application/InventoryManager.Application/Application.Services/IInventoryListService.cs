using InventoryManager.Application.DTOs;

namespace InventoryManager.Application.Services
{
    public interface IInventoryListService
    {
        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns></returns>
        InventoryItemDTO GetBussinessInventoryItemExample();

        /// <summary>
        /// Create a inventory Item
        /// </summary>
        /// <param name="inventoryItemDTO"></param>
        ValidationResultDTO Create(InventoryItemDTO inventoryItemDTO);

        /// <summary>
        /// Update a inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inventoryItemDTO"></param>
        ValidationResultDTO Update(int id, InventoryItemDTO inventoryItemDTO);

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        ValidationResultDTO Delete(int id);

        // <summary>
        /// Delete a inventory Item by a name
        /// </summary>
        /// <param name="name"></param>
        ValidationResultDTO DeleteByName(string name);

        /// <summary>
        /// Get inventory item by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        InventoryItemDTO GetInventoryItem(int id);

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <returns></returns>
        List<InventoryItemDTO> GetAllInventoryItems();

        /// <summary>
        /// Create a inventory Item
        /// </summary>
        /// <param name="inventoryItemDTO"></param>
        Task<ValidationResultDTO> CreateAsync(InventoryItemDTO inventoryItemDTO);

        /// <summary>
        /// Update a inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inventoryItemDTO"></param>
        Task<ValidationResultDTO> UpdateAsync(int id, InventoryItemDTO inventoryItemDTO);

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        Task<ValidationResultDTO> DeleteAsync(int id);

        /// <summary>
        /// Get inventory item by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<InventoryItemDTO> GetInventoryItemAsync(int id);

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <returns></returns>
        Task<List<InventoryItemDTO>> GetAllInventoryItemsAsync();
    }
}
