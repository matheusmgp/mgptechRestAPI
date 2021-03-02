using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        public User(){}
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column("senha", TypeName = "varchar(200)")]
        public string Senha { get; set; }
        [Column("token", TypeName = "text")]
        public string Token { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        [JsonIgnore]
        public Role Role { get; }
     
    }
}