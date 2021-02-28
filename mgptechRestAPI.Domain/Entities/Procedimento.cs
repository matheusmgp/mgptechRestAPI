using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Procedimento")]
    public class Procedimento : BaseEntity
    {
        public string DescricaoValue { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get; set; }
    }
}