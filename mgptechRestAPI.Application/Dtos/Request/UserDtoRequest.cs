using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class UserDtoRequest
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "Valor maximo de caracteres é 50")]
        [MinLength(5, ErrorMessage = "Valor minimo de caracteres é 5")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "O valor não é um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(6, ErrorMessage = "Valor maximo de caracteres é 6")]
        [MinLength(6, ErrorMessage = "Valor minimo de caracteres é 6")]
        public string Senha { get; set; }

        public string Token { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        public int AmbienteId { get; set; }
    }
}
