using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class FilialDtoRequest : BaseDtoEntity
    {
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(14, ErrorMessage = "Campo {0} deve conter 14 caracteres.")]
        [MinLength(14, ErrorMessage = "Campo {0} deve conter 14 caracteres.")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(50, ErrorMessage = "Campo {0} deve conter entre 5 e 50 caracteres.")]
        [MinLength(5, ErrorMessage = "Campo {0} deve conter entre 5 e 50 caracteres.")]
        public string RazaoSocial { get; set; }

        public string Status { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(50, ErrorMessage = "Campo {0} deve conter entre 5 e 50 caracteres.")]
        [MinLength(5, ErrorMessage = "Campo {0} deve conter entre 5 e 50 caracteres.")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int AmbienteId { get; set; }
    }
}
