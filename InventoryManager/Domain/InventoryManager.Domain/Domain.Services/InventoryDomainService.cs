using InventoryManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Domain.Services
{
    public class InventoryDomainService : IInventoryDomainService
    {        
        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns></returns>
        public InventoryItem GetBussinessInventoryItemExample() 
        { 
            return new BussinessInventoryItem() { Name = "Bussiness Item", Id=-999, ExpirationDate = DateTime.MaxValue };
        }
    }
}
