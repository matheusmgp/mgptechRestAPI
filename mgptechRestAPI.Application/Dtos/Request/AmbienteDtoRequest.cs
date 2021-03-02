using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class AmbienteDtoRequest : BaseDtoEntity
    {
      

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(50,ErrorMessage ="Valor maximo de caracteres é 50")]
        [MinLength(5, ErrorMessage = "Valor minimo de caracteres é 5")]
        
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "Valor maximo de caracteres é 50")]
        [MinLength(5, ErrorMessage = "Valor minimo de caracteres é 5")]
        
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(14, ErrorMessage = "Valor maximo de caracteres é 14")]
        [MinLength(14, ErrorMessage = "Valor minimo de caracteres é 14")]
       
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(11, ErrorMessage = "Valor maximo de caracteres é 11")]
        [MinLength(11, ErrorMessage = "Valor minimo de caracteres é 11")]
        
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "Valor maximo de caracteres é 50")]     
        [EmailAddress(ErrorMessage ="O valor não é um email válido")]
        
        public string Email { get; set; }

        public List<RoleDtoRequest> Roles { get; set; }

        public List<UserDtoRequest> Users { get; set; }
    }
}