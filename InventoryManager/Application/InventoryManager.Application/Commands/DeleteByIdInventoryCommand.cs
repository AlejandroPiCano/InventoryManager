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
    /// DeleteByIdInventoryCommand class.
    /// </summary>
    public class DeleteByIdInventoryCommand : IRequest<int>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// DeleteByNameInventoryCommandHandler class.
        /// </summary>
        public class DeleteByIdInventoryCommandHandler : IRequestHandler<DeleteByIdInventoryCommand, int>
        {
            IRepository<InventoryItem> repository;
            IMapper mapper;

            /// <summary>
            /// GetInventoryItemsHandler method.
            /// </summary>
            /// <param name="repository"></param>
            public DeleteByIdInventoryCommandHandler(IRepository<InventoryItem> repository, IMapper mapper)
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
            public async Task<int> Handle(DeleteByIdInventoryCommand request, CancellationToken cancellationToken)
            {
                await repository.DeleteAsync(request.Id);

                return request.Id;  
            }
        }
    }
}
