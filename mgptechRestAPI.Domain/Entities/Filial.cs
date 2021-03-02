using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Filial")]
    public class Filial : BaseEntity
    {
        [Column("cnpj", TypeName = "varchar(14)")]
        public string Cnpj { get; set; }
        [Column("razao_social", TypeName = "varchar(50)")]
        public string RazaoSocial { get; set; }
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
        [Column("nome_fantasia", TypeName = "varchar(50)")]
        public string NomeFantasia { get; set; }
       
    }
}