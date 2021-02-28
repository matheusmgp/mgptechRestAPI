using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Cliente")]
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public int AmbienteId { get; set; }

        [JsonIgnore]
        public Ambiente Ambiente { get; set; }
    }
}