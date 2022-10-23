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
    /// DeleteInventoryCommand class.
    /// </summary>
    public class DeleteByNameInventoryCommand : IRequest<string>
    {
        /// <summary>
        /// The Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// DeleteByNameInventoryCommandHandler class.
        /// </summary>
        public class DeleteByNameInventoryCommandHandler : IRequestHandler<DeleteByNameInventoryCommand, string>
        {
            IRepository<InventoryItem> repository;
            IMapper mapper;

            /// <summary>
            /// GetInventoryItemsHandler method.
            /// </summary>
            /// <param name="repository"></param>
            public DeleteByNameInventoryCommandHandler(IRepository<InventoryItem> repository, IMapper mapper)
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
            public async Task<string> Handle(DeleteByNameInventoryCommand request, CancellationToken cancellationToken)
            {
                await repository.DeleteByNameAsync(request.Name);

                return request.Name;  
            }
        }
    }
}
