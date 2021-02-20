using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class AmbienteDtoRequest
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
