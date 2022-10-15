using InventoryManager.Domain.Entities;

namespace InventoryManager.Domain.Domain.Services
{
    /// <summary>
    /// The Inventory Domain Service
    /// </summary>
    public class InventoryDomainService : IInventoryDomainService
    {
        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns></returns>
        public InventoryItem GetBussinessInventoryItemExample()
        {
            return new BussinessInventoryItem() { Name = "Bussiness Item", Id = -999, ExpirationDate = DateTime.MaxValue };
        }
    }
}
