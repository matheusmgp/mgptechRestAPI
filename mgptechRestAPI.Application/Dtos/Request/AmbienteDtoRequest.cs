using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class AmbienteDtoRequest
    {
        public int? Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public List<Role> Roles { get; set; }
        public List<User> Users { get; set; }
    }
}
