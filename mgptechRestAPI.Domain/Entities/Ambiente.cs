namespace mgptechRestAPI.Domain.Entities
{
    public class Ambiente : BaseEntity
    {

        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
