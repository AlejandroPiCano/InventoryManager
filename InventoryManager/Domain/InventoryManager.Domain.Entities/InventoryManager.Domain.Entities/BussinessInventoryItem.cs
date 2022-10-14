
namespace InventoryManager.Domain.Entities
{
    public class BussinessInventoryItem : InventoryItem
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int Type { get; set; }
    }
}