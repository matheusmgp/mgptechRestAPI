using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class UserAuthDtoRequest
    {
        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "O valor não é um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(6, ErrorMessage = "Valor maximo de caracteres é 6")]
        [MinLength(6, ErrorMessage = "Valor minimo de caracteres é 6")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        public int RoleId { get; set; }
    }
}