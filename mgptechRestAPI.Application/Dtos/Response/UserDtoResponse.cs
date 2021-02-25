using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Dtos.Response
{
    public class UserDtoResponse : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public int RoleId { get; set; }
        public int AmbienteId { get; set; }
    }
}