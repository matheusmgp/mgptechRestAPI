namespace mgptechRestAPI.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}