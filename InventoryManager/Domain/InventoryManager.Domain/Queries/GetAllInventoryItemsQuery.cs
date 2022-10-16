using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Queries
{
    /// <summary>
    /// GetAllInventoryItemsQuery class.
    /// </summary>
    public class GetAllInventoryItemsQuery : IRequest<List<InventoryItem>>
    {
        /// <summary>
        /// GetAllInventoryItemsHandler class.
        /// </summary>
        public class GetAllInventoryItemsHandler : IRequestHandler<GetAllInventoryItemsQuery, List<InventoryItem>>
        {
            IRepository<InventoryItem> repository;

            /// <summary>
            /// GetAllInventoryItemsHandler method.
            /// </summary>
            /// <param name="repository"></param>
            public GetAllInventoryItemsHandler(IRepository<InventoryItem> repository)
            {
                this.repository = repository;
            }

            /// <summary>
            /// The Handle method.
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<List<InventoryItem>> Handle(GetAllInventoryItemsQuery request, CancellationToken cancellationToken)
            {
                return await repository.GetAllAsync();
            }
        }
    }
}
