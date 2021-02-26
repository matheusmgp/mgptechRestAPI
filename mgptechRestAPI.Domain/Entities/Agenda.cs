using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Agendas")]
    public class Agenda : BaseEntity
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string? Observacao { get; set; }

        public int AmbienteId { get; set; }

        [JsonIgnore]
        public Ambiente Ambiente { get; set; }
    }
}