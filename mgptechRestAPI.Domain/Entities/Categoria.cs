using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Categoria")]
    public class Categoria : BaseEntity
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get;  }
    }
}