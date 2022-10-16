using System.Runtime.Serialization;

namespace InventoryManager.Domain.Commands
{
    public class InventoryItemCommand
    {
        /// <summary>
        /// The Name
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Expiration Date
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The Type
        /// </summary>
        public int Type { get; set; }
    }
}