using InventoryManager.Domain.Entities;

namespace InventoryManager.Infrastructure.Entities
{
    public class DefaultInventoryItem : InventoryItem
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int Type { get; set; }
    }
}