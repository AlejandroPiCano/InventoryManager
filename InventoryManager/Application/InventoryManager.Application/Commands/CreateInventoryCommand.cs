﻿using AutoMapper;
using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Commands
{
    /// <summary>
    /// CreateInventoryCommand class.
    /// </summary>
    public class CreateInventoryCommand : InventoryItemCommand, IRequest<int>
    {
        /// <summary>
        /// CreateInventoryCommandHandlers class.
        /// </summary>
        public class CreateInventoryCommandHandler : IRequestHandler<CreateInventoryCommand, int>
        {
            IRepository<InventoryItem> repository;
            IMapper mapper;

            /// <summary>
            /// GetInventoryItemsHandler method.
            /// </summary>
            /// <param name="repository"></param>
            public CreateInventoryCommandHandler(IRepository<InventoryItem> repository, IMapper mapper)
            {
                this.repository = repository;
                this.mapper = mapper;
            }

            /// <summary>
            /// The Handle method.
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<int> Handle(CreateInventoryCommand request, CancellationToken cancellationToken)
            {
                await repository.CreateAsync(mapper.Map<InventoryItem>(request));

                return request.Id;  
            }
        }
    }
}
