using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("SubCategoria")]
    public class SubCategoria : BaseEntity
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public int CategoriaId { get; set; }

        [JsonIgnore]
        public Categoria Categoria { get; set; }

        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get;  }
    }
}