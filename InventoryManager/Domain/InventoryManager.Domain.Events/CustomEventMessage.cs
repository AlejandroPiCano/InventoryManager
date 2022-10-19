using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Events
{
    /// <summary>
    /// The Custom Event Message class.
    /// </summary>
    public class CustomEventMessage
    {
        /// <summary>
        /// The Identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The CustomEventMessage constructor
        /// </summary>
        /// <param name="id"></param>
        public CustomEventMessage(Guid id)
        {
            Id = id;
        }        
    }
}
