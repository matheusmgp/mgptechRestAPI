using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("SubCategoria")]
    public class SubCategoria : BaseEntity

    {
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
        [Column("categoria_id")]
        public int CategoriaId { get; set; }
        [JsonIgnore]
        public Categoria Categoria { get;  }
      
    }
}