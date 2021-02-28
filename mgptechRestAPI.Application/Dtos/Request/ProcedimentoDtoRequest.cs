using System;
using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class ProcedimentoDtoRequest : BaseDtoEntity
    {
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(300, ErrorMessage = "Campo {0} deve no máximo 300 caracteres.")]
        public string DescricaoValue { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(300, ErrorMessage = "Campo {0} deve no máximo 300 caracteres.")]
        public string Descricao { get; set; }

        public string Status { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int AmbienteId { get; set; }
    }
}