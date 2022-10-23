using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Events
{
    /// <summary>
    /// The ICustomEventManager interface
    /// </summary>
    public interface ICustomEventManager
    {
        /// <summary>
        /// The SendItemExpiredEvent method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expirationDate"></param>
        /// <returns>The Task of this action.</returns>
        Task SendItemExpiredEvent(string name, DateTime? expirationDate);

        /// <summary>
        /// The SendItemRemovedEvent
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The Task of this action.</returns>
        Task SendItemRemovedEvent(string name);
    }
}
