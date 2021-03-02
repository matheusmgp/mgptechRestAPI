using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Cliente")]
    public class Cliente : BaseEntity
    {
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
      
    }
}