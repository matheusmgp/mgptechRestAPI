using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class ClienteDtoRequest : BaseDtoEntity
    {
        [Required(ErrorMessage = "O {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "Valor maximo de caracteres é 50")]
        [MinLength(5, ErrorMessage = "Valor minimo de caracteres é 5")]
        public string Nome { get; set; }
        public string Status { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int AmbienteId { get; set; }
    }
}