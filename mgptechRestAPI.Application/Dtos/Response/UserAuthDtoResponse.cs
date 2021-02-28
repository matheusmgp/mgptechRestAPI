using mgptechRestAPI.Domain.Entities;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Application.Dtos.Response
{
    public class UserAuthDtoResponse : BaseDtoEntity
    {
        
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }

        //[JsonIgnore]
        // public Role Role { get; }
    }
}