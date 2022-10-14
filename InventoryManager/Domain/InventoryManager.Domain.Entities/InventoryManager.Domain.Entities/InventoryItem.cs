namespace InventoryManager.Domain.Entities
{
    public interface InventoryItem
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime? ExpirationDate { get; set; }
        int Type { get; set; }
    }
}