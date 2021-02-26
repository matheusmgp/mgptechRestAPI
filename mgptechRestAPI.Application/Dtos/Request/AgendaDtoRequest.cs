using System;
using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class AgendaDtoRequest
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MaxLength(40, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MaxLength(9, ErrorMessage = "Este campo deve conter entre 8 e 9 caracteres.")]
        [MinLength(8, ErrorMessage = "Este campo deve conter entre 8 e 9 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MaxLength(35, ErrorMessage = "Este campo deve conter entre 15 e 35 caracteres.")]
        [MinLength(15, ErrorMessage = "Este campo deve conter entre 15 e 35 caracteres.")]
        [EmailAddress(ErrorMessage = "o campo email precisa de um email válido.")]
        public string Email { get; set; }

        [MaxLength(100, ErrorMessage = "Este campo deve no máximo 100 caracteres.")]
        public string? Observacao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int AmbienteId { get; set; }
    }
}