using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Events
{
    /// <summary>
    /// The ItemRemoved class.
    /// </summary>
    public class ItemRemoved: CustomEventMessage
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The ItemRemoved constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public ItemRemoved(Guid id, string name):base(id)
        {            
            this.Name = name;
        }        
    }
}
