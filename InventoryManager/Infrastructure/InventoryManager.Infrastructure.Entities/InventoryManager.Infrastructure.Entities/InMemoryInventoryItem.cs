using InventoryManager.Domain.Entities;

namespace InventoryManager.Infrastructure.Entities
{
    /// <summary>
    /// The InMemoryInventoryItem class
    /// </summary>
    public class InMemoryInventoryItem : InventoryItem
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The expiration date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The Type.
        /// </summary>
        public int Type { get; set; }
    }
}