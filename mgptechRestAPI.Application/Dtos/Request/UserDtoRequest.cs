using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class UserDtoRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public int RoleId { get; set; }
    }
}
