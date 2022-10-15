using FluentValidation;
using FluentValidation.Results;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Domain.Services;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;

namespace InventoryManager.Application.Services
{
    /// <summary>
    /// The Inventory List Service.
    /// </summary>
    public class InventoryListService : IInventoryListService
    {
        readonly IInventoryDomainService inventoryListDomainService;
        readonly IRepository<InventoryItem> inventoryListRepository;
        readonly IValidator<InventoryItemDTO> validator;

        /// <summary>
        /// The InventoryListService constructor.
        /// </summary>
        /// <param name="inventoryListDomainService"></param>
        /// <param name="inventoryListRepository"></param>
        /// <param name="validator"></param>
        public InventoryListService(IInventoryDomainService inventoryListDomainService, IRepository<InventoryItem> inventoryListRepository, IValidator<InventoryItemDTO> validator)
        {
            this.inventoryListDomainService = inventoryListDomainService;
            this.inventoryListRepository = inventoryListRepository;
            this.validator = validator;
        }

        #region Interface Implementation

        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns></returns>
        InventoryItemDTO IInventoryListService.GetBussinessInventoryItemExample()
        {
            return InventoryItemConverter.ConvertInventoryItemEntityToDTO(inventoryListDomainService.GetBussinessInventoryItemExample());
        }

        /// Create a inventory Item
        /// </summary>
        /// <param name="inventoryItem"></param>
        ValidationResult IInventoryListService.Create(InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                this.inventoryListRepository.Create(InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew(), true));
            }

            return result;
        }

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        ValidationResult IInventoryListService.Delete(int id)
        {
            this.inventoryListRepository.Delete(id);

            return new ValidationResult();
        }

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <returns></returns>
        List<InventoryItemDTO> IInventoryListService.GetAllInventoryItems()
        {
            return this.inventoryListRepository.GetAll().Select(i => InventoryItemConverter.ConvertInventoryItemEntityToDTO(i)).ToList();
        }

        /// <summary>
        /// Get inventory item by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        InventoryItemDTO IInventoryListService.GetInventoryItem(int id)
        {
            var inventoryItem = this.inventoryListRepository.Get(id);

            return InventoryItemConverter.ConvertInventoryItemEntityToDTO(inventoryItem);
        }

        /// <summary>
        /// Update a inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inventoryItemDTO"></param>
        ValidationResult IInventoryListService.Update(int id, InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                this.inventoryListRepository.Update(id, InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew()));
            }

            return result;
        }

        public async Task<List<InventoryItemDTO>> GetAllInventoryItemsAsync()
        {
            var result = await this.inventoryListRepository.GetAllAsync();

            return result.Select(i => InventoryItemConverter.ConvertInventoryItemEntityToDTO(i)).ToList();
        }

        public async Task<ValidationResult> CreateAsync(InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                await this.inventoryListRepository.CreateAsync(InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew(), true));
            }

            return result;
        }

        public async Task<ValidationResult> UpdateAsync(int id, InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                await this.inventoryListRepository.UpdateAsync(id, InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew()));
            }

            return result;
        }

        public async Task<ValidationResult> DeleteAsync(int id)
        {
            await this.inventoryListRepository.DeleteAsync(id);

            return new ValidationResult();
        }

        public async Task<InventoryItemDTO> GetInventoryItemAsync(int id)
        {
            var inventoryItem = await this.inventoryListRepository.GetAsync(id);

            return InventoryItemConverter.ConvertInventoryItemEntityToDTO(inventoryItem);
        }

        public ValidationResult DeleteByName(string name)
        {
            this.inventoryListRepository.DeleteByName(name);

            return new ValidationResult();
        }
        #endregion
    }
}
