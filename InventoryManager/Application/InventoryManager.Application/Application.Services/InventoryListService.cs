using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Domain.Services;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;

namespace InventoryManager.Application.Services
{
    public class InventoryListService : IInventoryListService
    {
        readonly IInventoryDomainService inventoryListDomainService;
        readonly IRepository<InventoryItem> inventoryListRepository;

        public InventoryListService(IInventoryDomainService inventoryListDomainService, IRepository<InventoryItem> inventoryListRepository)
        {
            this.inventoryListDomainService = inventoryListDomainService;
            this.inventoryListRepository = inventoryListRepository;
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
        ValidationResultDTO IInventoryListService.Create(InventoryItemDTO inventoryItemDTO)
        {
            var result = inventoryItemDTO.CheckValidation();

            if (result.Result == ResultTypeDTO.Ok)
            {
                this.inventoryListRepository.Create(InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew(), true));
            }

            return result;
        }

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        ValidationResultDTO IInventoryListService.Delete(int id)
        {
            this.inventoryListRepository.Delete(id);

            return new ValidationResultDTO();
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
        ValidationResultDTO IInventoryListService.Update(int id, InventoryItemDTO inventoryItemDTO)
        {
            var result = inventoryItemDTO.CheckValidation();

            if (result.Result == ResultTypeDTO.Ok)
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

        public async Task<ValidationResultDTO> CreateAsync(InventoryItemDTO inventoryItemDTO)
        {
            var result = inventoryItemDTO.CheckValidation();

            if (result.Result == ResultTypeDTO.Ok)
            {
                await this.inventoryListRepository.CreateAsync(InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew(), true));
            }

            return result;
        }

        public async Task<ValidationResultDTO> UpdateAsync(int id, InventoryItemDTO inventoryItemDTO)
        {
            var result = inventoryItemDTO.CheckValidation();

            if (result.Result == ResultTypeDTO.Ok)
            {
                await this.inventoryListRepository.UpdateAsync(id, InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew()));
            }

            return result;
        }

        public async Task<ValidationResultDTO> DeleteAsync(int id)
        {
            await this.inventoryListRepository.DeleteAsync(id);

            return new ValidationResultDTO();
        }

        public async Task<InventoryItemDTO> GetInventoryItemAsync(int id)
        {
            var inventoryItem = await this.inventoryListRepository.GetAsync(id);

            return InventoryItemConverter.ConvertInventoryItemEntityToDTO(inventoryItem);
        }

        public ValidationResultDTO DeleteByName(string name)
        {
            this.inventoryListRepository.DeleteByName(name);

            return new ValidationResultDTO();
        }
        #endregion
    }
}
