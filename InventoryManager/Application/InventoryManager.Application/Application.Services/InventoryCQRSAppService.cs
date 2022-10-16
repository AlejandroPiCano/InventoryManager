using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using InventoryManager.Application.DTOs;
using InventoryManager.Domain.Commands;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Queries;
using InventoryManager.Domain.Repository.Contracts;
using InventoryManager.Domain.Services;
using MediatR;
using System.Collections.Generic;

namespace InventoryManager.Application.Services
{
    /// <summary>
    /// The Inventory App Service class.
    /// </summary>
    public class InventoryCQRSAppService : IInventoryAppService
    {
        readonly IInventoryDomainService inventoryListDomainService;
        readonly IRepository<InventoryItem> inventoryListRepository;
        readonly IValidator<InventoryItemDTO> validator;
        readonly IMapper mapper;
        readonly IMediator mediator;

        /// <summary>
        /// The InventoryListService constructor.
        /// </summary>
        /// <param name="inventoryListDomainService"></param>
        /// <param name="inventoryListRepository"></param>
        /// <param name="validator"></param>
        public InventoryCQRSAppService(IInventoryDomainService inventoryListDomainService, IRepository<InventoryItem> inventoryListRepository, IValidator<InventoryItemDTO> validator, IMapper mapper, IMediator mediator)
        {
            this.inventoryListDomainService = inventoryListDomainService;
            this.inventoryListRepository = inventoryListRepository;
            this.validator = validator;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        #region Interface Implementation

        #region Queries
        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns></returns>
        InventoryItemDTO IInventoryAppService.GetBussinessInventoryItemExample()
        {
            return mapper.Map<InventoryItemDTO>(inventoryListDomainService.GetBussinessInventoryItemExample());
        }

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <returns></returns>
        async Task<List<InventoryItemDTO>> IInventoryAppService.GetAllInventoryItemsAsync()
        {
            return mapper.Map<List<InventoryItemDTO>>(await mediator.Send(new GetAllInventoryItemsQuery()));
        }

        public async Task<InventoryItemDTO> GetInventoryItemAsync(int id)
        {
            return mapper.Map<InventoryItemDTO>(await mediator.Send(new GetInventoryItemQuery(id)));
        }

        #endregion

        #region Commands
        /// <summary>
        /// CreateAsync Method
        /// </summary>
        /// <param name="inventoryItemDTO"></param>
        /// <returns></returns>
        public async Task<ValidationResult> CreateAsync(InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                await mediator.Send(mapper.Map<CreateInventoryCommand>(inventoryItemDTO));
            }

            return result;
        }


        public async Task<ValidationResult> UpdateAsync(int id, InventoryItemDTO inventoryItemDTO)
        {
            ValidationResult result = validator.Validate(inventoryItemDTO);

            if (result.IsValid)
            {
                await mediator.Send(mapper.Map<UpdateInventoryCommand>(inventoryItemDTO));
            }

            return result;
        }

        public async Task<ValidationResult> DeleteAsync(int id)
        {
            await mediator.Send(new DeleteByIdInventoryCommand() { Id = id});

            return new ValidationResult();
        }


        public async Task<ValidationResult> DeleteByNameAsync(string name)
        {
            await mediator.Send(new DeleteByNameInventoryCommand() { Name = name }) ;

            return new ValidationResult();
        }

        #endregion
    }
    #endregion
}
