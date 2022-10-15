using System.Runtime.Serialization;

namespace InventoryManager.Application.DTOs
{
    /// <summary>
    /// The DTO base class.
    /// </summary>
    [DataContract]
    public abstract class DTO
    {
        /// <summary>
        /// The Identifier.
        /// </summary>
        [DataMember]
        public int Id { get; set; }
    }
}