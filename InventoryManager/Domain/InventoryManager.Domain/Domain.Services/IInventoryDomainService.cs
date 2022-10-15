using InventoryManager.Domain.Entities;

namespace InventoryManager.Domain.Domain.Services
{
    /// <summary>
    /// The IInventoryDomainService interface.
    /// </summary>
    public interface IInventoryDomainService
    {
        /// <summary>
        /// Get bussiness Inventory item. Only for example.
        /// </summary>
        /// <returns></returns>
        InventoryItem GetBussinessInventoryItemExample();
    }
}
