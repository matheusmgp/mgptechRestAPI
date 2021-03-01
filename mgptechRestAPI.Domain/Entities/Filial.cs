using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Filial")]
    public class Filial : BaseEntity
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Status { get; set; }
        public string NomeFantasia { get; set; }
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get; set; }
    }
}