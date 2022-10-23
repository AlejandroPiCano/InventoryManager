using InventoryManager.Domain.Entities;
using InventoryManager.Domain.Repository.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Queries
{
    /// <summary>
    /// GetInventoryItemsQuery class.
    /// </summary>
    public class GetInventoryItemQuery : IRequest<InventoryItem>
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public GetInventoryItemQuery(int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// GetInventoryItemsHandler class.
        /// </summary>
        public class GetInventoryItemHandler : IRequestHandler<GetInventoryItemQuery, InventoryItem>
        {
            IRepository<InventoryItem> repository;

            /// <summary>
            /// GetInventoryItemsHandler method.
            /// </summary>
            /// <param name="repository"></param>
            public GetInventoryItemHandler(IRepository<InventoryItem> repository)
            {
                this.repository = repository;
            }

            /// <summary>
            /// The Handle method.
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<InventoryItem> Handle(GetInventoryItemQuery request, CancellationToken cancellationToken)
            {
                return await repository.GetAsync(request.Id);
            }
        }
    }
}
