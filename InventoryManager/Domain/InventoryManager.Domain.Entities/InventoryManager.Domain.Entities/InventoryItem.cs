namespace InventoryManager.Domain.Entities
{
    /// <summary>
    /// The InventoryItem
    /// </summary>
    public interface InventoryItem
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// The Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The Expiration date
        /// </summary>
        DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The Type.
        /// </summary>
        int Type { get; set; }
    }
}