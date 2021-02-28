using System;
using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class SetorDtoRequest : BaseDtoEntity
    {
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(40, ErrorMessage = "Campo {0} deve conter entre 3 e 40 caracteres.")]
        [MinLength(3, ErrorMessage = "Campo {0} deve conter entre 3 e 40 caracteres.")]
        public string Nome { get; set; }

        public string Status { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string Tempo { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string TempoRapido { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string TempoMedio { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int AmbienteId { get; set; }
    }
}