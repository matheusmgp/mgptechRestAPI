using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        public User()
        {
                
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public int RoleId { get; set; }
        [JsonIgnore]
        public Role Role { get; }
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get; }
    }
}