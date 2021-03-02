using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Setor")]
    public class Setor : BaseEntity
    {
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
        [Column("tempo", TypeName = "varchar(10)")]
        public string Tempo { get; set; }
        [Column("tempo_rapido", TypeName = "varchar(10)")]
        public string TempoRapido { get; set; }
        [Column("tempo_medio", TypeName = "varchar(10)")]
        public string TempoMedio { get; set; }
    }
}