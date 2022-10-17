using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Events
{
    /// <summary>
    /// The ItemExpirded class.
    /// </summary>
    public class ItemExpired : CustomEventMessage
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The expiration date
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The ItemExpired constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="expirationDate"></param>
        public ItemExpired(Guid id, string name, DateTime? expirationDate) :base(id)
        {            
            this.Name = name;
            this.ExpirationDate = expirationDate;
        }        
    }
}
