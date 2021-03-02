using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Role")]
    public class Role : BaseEntity
    {
        public Role(){}

        [Column("role_id")]
        public int RoleId { get; set; }
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
      
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
       
    }
}