using AutoMapper;
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
    /// UpdateInventoryCommand class.
    /// </summary>
    public class UpdateInventoryCommand : InventoryItemCommand, IRequest<int>
    {
        /// <summary>
        /// The Resquest inventory item Id
        /// </summary>
        public int RequestInventoryItemId { get; set; }

        /// <summary>
        ///UpdateInventoryCommandHandlers class.
        /// </summary>
        public class UpdateInventoryCommandHandler : IRequestHandler<UpdateInventoryCommand, int>
        {
            IRepository<InventoryItem> repository;
            IMapper mapper;

            /// <summary>
            /// GetInventoryItemsHandler method.
            /// </summary>
            /// <param name="repository"></param>
            public UpdateInventoryCommandHandler(IRepository<InventoryItem> repository, IMapper mapper)
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
            public async Task<int> Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
            {
                await repository.UpdateAsync(request.RequestInventoryItemId, mapper.Map<InventoryItem>(request));

                return request.Id;  
            }
        }
    }
}
