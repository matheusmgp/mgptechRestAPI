using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Procedimento")]
    public class Procedimento : BaseEntity
    {
        [Column("descricao_value", TypeName = "varchar(300)")]
        public string DescricaoValue { get; set; }
        [Column("descricao", TypeName = "varchar(300)")]
        public string Descricao { get; set; }
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
    } 
}