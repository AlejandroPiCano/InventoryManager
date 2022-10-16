using InventoryManager.Domain.Entities;

namespace InventoryManager.Domain.Entities
{
    /// <summary>
    /// The InventoryItem class
    /// </summary>
    public class InventoryItem
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