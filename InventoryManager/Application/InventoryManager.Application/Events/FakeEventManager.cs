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
    public class FakeEventManager : ICustomEventManager
    {
        /// <summary>
        /// The SendItemExpiredEvent method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expirationDate"></param>
        /// <returns>The Task of this action.</returns>
        public async Task SendItemExpiredEvent(string name, DateTime? expirationDate)
        {
           await Task.Run(() => { });
        }

        /// <summary>
        /// The SendItemRemovedEvent method
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The Task of this action.</returns>
        public async Task SendItemRemovedEvent(string name)
        {
            await Task.Run(() => { });
        }
    }
}
