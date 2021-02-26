using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Ambiente")]
    public class Ambiente : BaseEntity
    {
        public Ambiente(){}
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public IEnumerable<Role> Roles { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}