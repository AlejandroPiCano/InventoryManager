﻿using FluentValidation.Results;
using InventoryManager.Application.DTOs;

namespace InventoryManager.Application.Services
{
    /// <summary>
    /// The IInventoryAppService interface.
    /// </summary>
    public interface IInventoryAppService
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
        Task<ValidationResult> CreateAsync(InventoryItemDTO inventoryItemDTO);

        /// <summary>
        /// Update a inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inventoryItemDTO"></param>
        Task<ValidationResult> UpdateAsync(int id, InventoryItemDTO inventoryItemDTO);

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        Task<ValidationResult> DeleteAsync(int id);

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        Task<ValidationResult> DeleteByNameAsync(string name);

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
