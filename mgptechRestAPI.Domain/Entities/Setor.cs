using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Setor")]
    public class Setor : BaseEntity
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public string Tempo { get; set; }
        public string TempoRapido { get; set; }
        public string TempoMedio { get; set; }
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get; set; }
    }
}