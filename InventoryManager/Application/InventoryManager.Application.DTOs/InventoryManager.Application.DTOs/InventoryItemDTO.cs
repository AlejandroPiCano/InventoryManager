using System.Runtime.Serialization;

namespace InventoryManager.Application.DTOs
{
    [DataContract]
    public class InventoryItemDTO : DTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime? ExpirationDate { get; set; }

        [DataMember]
        public int Type { get; set; }

        public new ValidationResultDTO CheckValidation()
        {
            ValidationResultDTO result = new ValidationResultDTO();

            if (string.IsNullOrEmpty(Name))
            {
                result.Result = ResultTypeDTO.Error;
                result.Errors.Add(string.Format("The field {0} must be have value", nameof(Name)));
            }

            if (Id < 0)
            {
                result.Result = ResultTypeDTO.Error;
                result.Errors.Add(string.Format("The field {0} must be a non negative value", nameof(Id)));
            }

            return result;
        }
    }
}