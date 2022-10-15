using System.Runtime.Serialization;

namespace InventoryManager.Application.DTOs
{
    /// <summary>
    /// The InventoryItem DTO.
    /// </summary>
    [DataContract]
    public class InventoryItemDTO : DTO
    {
        /// <summary>
        /// The Name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// The Expiration Date
        /// </summary>
        [DataMember]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The Type
        /// </summary>
        [DataMember]
        public int Type { get; set; }
    }
}