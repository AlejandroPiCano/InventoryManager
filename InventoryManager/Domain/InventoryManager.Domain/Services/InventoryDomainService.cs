using InventoryManager.Domain.Entities;

namespace InventoryManager.Domain.Services
{
    /// <summary>
    /// The Inventory Domain Service
    /// </summary>
    public class InventoryDomainService : IInventoryDomainService
    {
        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns>The Inventory item</returns>
        public InventoryItem GetBussinessInventoryItemExample()
        {
            return new InventoryItem() { Name = "Bussiness Item", Id = -999, ExpirationDate = DateTime.MaxValue };
        }
    }
}
