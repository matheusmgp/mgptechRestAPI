using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Role")]
    public class Role : BaseEntity
    {
        public Role(){}

        public int RoleId { get; set; }
        public string Nome { get; set; }
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get; }
    }
}