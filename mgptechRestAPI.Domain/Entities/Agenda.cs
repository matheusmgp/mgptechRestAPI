using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Agendas")]
    public class Agenda : BaseEntity
    {
        [Column("nome",TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Column("telefone", TypeName = "varchar(15)")]
        public string Telefone { get; set; }

        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column("observacao", TypeName = "text")]
        public string? Observacao { get; set; }      

      
    }
}