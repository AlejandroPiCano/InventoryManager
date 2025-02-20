﻿using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Services;
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

        public async Task<ValidationResult> DeleteByNameAsync(string name)
        {
            await this.inventoryListRepository.DeleteByNameAsync(name);

            return new ValidationResult();
        }
        #endregion
    }
}
