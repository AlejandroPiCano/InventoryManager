using System.Collections.Generic;
using System.Runtime.Serialization;

namespace InventoryManager.Application.DTOs
{
    [DataContract]
    public class ValidationResultDTO: DTO
    {
        [DataMember]
        public ResultTypeDTO Result { get; set; }

        [DataMember]
        public List<string> Errors { get; set; }

        public ValidationResultDTO()
        {
            Result = ResultTypeDTO.Ok;
            Errors = new List<string>();
        }
    }
}