using System.Runtime.Serialization;

namespace InventoryManager.Application.DTOs
{
    public abstract class DTO
    {
        public ValidationResultDTO CheckValidation()
        {
            return new ValidationResultDTO();
        }
    }
}