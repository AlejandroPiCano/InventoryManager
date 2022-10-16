using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Domain.Services;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using System.Runtime.CompilerServices;

namespace InventoryManager.Application.Services
{
    /// <summary>
    /// The Inventory App Service class.
    /// </summary>
    public class InventoryAppService : IInventoryAppService
    {
        readonly IInventoryDomainService inventoryListDomainService;
        readonly IRepository<InventoryItem> inventoryListRepository;
        readonly IValidator<InventoryItemDTO> validator;
        IMapper mapper;        

        /// <summary>
        /// The InventoryListService constructor.
        /// </summary>
        /// <param name="inventoryListDomainService"></param>
        /// <param name="inventoryListRepository"></param>
        /// <param name="validator"></param>
        public InventoryAppService(IInventoryDomainService inventoryListDomainService, IRepository<InventoryItem> inventoryListRepository, IValidator<InventoryItemDTO> validator, IMapper mapper)
        {
            this.inventoryListDomainService = inventoryListDomainService;
            this.inventoryListRepository = inventoryListRepository;
            this.validator = validator;
            this.mapper = mapper;
        }

        #region Interface Implementation

        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns></returns>
        InventoryItemDTO IInventoryAppService.GetBussinessInventoryItemExample()
        {
            return mapper.Map<InventoryItemDTO>(inventoryListDomainService.GetBussinessInventoryItemExample());            
        }

        /// Create a inventory Item
        /// </summary>
        /// <param name="inventoryItem"></param>
        ValidationResult IInventoryAppService.Create(InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                //this.inventoryListRepository.Create(InventoryItemConverter.ConvertInventoryDTOToEntitiy(inventoryItemDTO, inventoryListRepository.GetNew(), true));

                inventoryListRepository.Create(mapper.Map<InventoryItem>(inventoryItemDTO));                
            }

            return result;
        }

        /// <summary>
        /// Delete a inventory Item 
        /// </summary>
        /// <param name="id"></param>
        ValidationResult IInventoryAppService.Delete(int id)
        {
            this.inventoryListRepository.Delete(id);

            return new ValidationResult();
        }

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <returns></returns>
        List<InventoryItemDTO> IInventoryAppService.GetAllInventoryItems()
        {
            return this.inventoryListRepository.GetAll().Select(i => mapper.Map<InventoryItemDTO>(i)).ToList();
        }

        /// <summary>
        /// Get inventory item by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        InventoryItemDTO IInventoryAppService.GetInventoryItem(int id)
        {
            var inventoryItem = this.inventoryListRepository.Get(id);

            return mapper.Map<InventoryItemDTO>(inventoryItem);
        }

        /// <summary>
        /// Update a inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inventoryItemDTO"></param>
        ValidationResult IInventoryAppService.Update(int id, InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                this.inventoryListRepository.Update(id, mapper.Map<InventoryItem>(inventoryItemDTO));
            }

            return result;
        }

        public async Task<List<InventoryItemDTO>> GetAllInventoryItemsAsync()
        {
            var result = await this.inventoryListRepository.GetAllAsync();

            return result.Select(i => mapper.Map<InventoryItemDTO>(i)).ToList();
        }

        public async Task<ValidationResult> CreateAsync(InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                await this.inventoryListRepository.CreateAsync(mapper.Map<InventoryItem>(inventoryItemDTO));
            }

            return result;
        }

        public async Task<ValidationResult> UpdateAsync(int id, InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                await this.inventoryListRepository.UpdateAsync(id, mapper.Map<InventoryItem>(inventoryItemDTO));
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

            return mapper.Map<InventoryItemDTO>(inventoryItem);
        }

        public ValidationResult DeleteByName(string name)
        {
            this.inventoryListRepository.DeleteByName(name);

            return new ValidationResult();
        }
        #endregion
    }
}
