using mgptechRestAPI.Domain.Entities;
using System.Collections.Generic;

namespace mgptechRestAPI.Application.Dtos.Response
{
    public class AmbienteDtoResponse : BaseEntity
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public List<Role> Roles { get; set; }
        public List<User> Users { get; set; }
    }
}