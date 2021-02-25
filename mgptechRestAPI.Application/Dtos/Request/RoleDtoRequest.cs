using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class RoleDtoRequest
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "Valor maximo de caracteres é 50")]
        [MinLength(5, ErrorMessage = "Valor minimo de caracteres é 5")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        public int AmbienteId { get; set; }
    }
}