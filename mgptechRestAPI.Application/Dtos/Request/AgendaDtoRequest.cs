using System;
using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class AgendaDtoRequest : BaseDtoEntity
    {
       

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(40, ErrorMessage = "Campo {0} deve conter entre 3 e 40 caracteres.")]
        [MinLength(3, ErrorMessage = "Campo {0} deve conter entre 3 e 40 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(9, ErrorMessage = "Campo {0} deve conter entre 8 e 9 caracteres.")]
        [MinLength(8, ErrorMessage = "Campo {0} deve conter entre 8 e 9 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(35, ErrorMessage = "Campo {0} deve conter entre 15 e 35 caracteres.")]
        [MinLength(15, ErrorMessage = "Campo {0} deve conter entre 15 e 35 caracteres.")]
        [EmailAddress(ErrorMessage = "Campo {0} precisa de um email válido.")]
        public string Email { get; set; }

        [MaxLength(100, ErrorMessage = "Campo {0} deve no máximo 100 caracteres.")]
        public string? Observacao { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int AmbienteId { get; set; }
    }
}