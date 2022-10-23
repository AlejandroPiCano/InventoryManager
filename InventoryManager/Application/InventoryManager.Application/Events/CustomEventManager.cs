using InventoryManager.Domain.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Events
{
    /// <summary>
    /// The CustomEventManager class
    /// </summary>
    public class CustomEventManager : ICustomEventManager
    {
        /// <summary>
        /// The publishEndpoint.
        /// </summary>
        readonly IPublishEndpoint publishEndpoint;

        /// <summary>
        /// The CustomEventManager constructor.
        /// </summary>
        /// <param name="publishEndpoint"></param>
        public CustomEventManager(IPublishEndpoint publishEndpoint)
        { 
            this.publishEndpoint = publishEndpoint;
        }

        /// <summary>
        /// The SendItemExpiredEvent method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expirationDate"></param>
        /// <returns>The Task of this action.</returns>
        public async Task SendItemExpiredEvent(string name, DateTime? expirationDate)
        {
            if (expirationDate.HasValue && expirationDate.Value <= DateTime.Now)
            {
                await publishEndpoint.Publish<ItemExpired>(new ItemExpired(Guid.NewGuid(), name, expirationDate));
            }
        }

        /// <summary>
        /// The SendItemRemovedEvent method
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The Task of this action.</returns>
        public async Task SendItemRemovedEvent(string name)
        {
            await publishEndpoint.Publish<ItemRemoved>(new ItemRemoved(Guid.NewGuid(), name));
        }
    }
}
