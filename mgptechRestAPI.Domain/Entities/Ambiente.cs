using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Ambiente")]
    public class Ambiente 
    {
        public Ambiente(){}

        public int Id { get; set; }
        [Column("nome_fantasia", TypeName = "varchar(50)")]
        public string NomeFantasia { get; set; }
        [Column("data_cadastro", TypeName = "dateTime2")]
        public DateTime DataCadastro { get; set; }
        [Column("razao_social", TypeName = "varchar(50)")]
        public string RazaoSocial { get; set; }
        [Column("cnpj", TypeName = "varchar(14)")]
        public string Cnpj { get; set; }
        [Column("cpf", TypeName = "varchar(11)")]
        public string Cpf { get; set; }
        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; }
        public IEnumerable<Role> Roles { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}