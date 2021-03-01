using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class PendenciaDtoRequest : BaseDtoEntity
    {
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [MaxLength(300, ErrorMessage = "Campo {0} deve conter entre 10 e 300 caracteres.")]
        [MinLength(10, ErrorMessage = "Campo {0} deve conter entre 10 e 300 caracteres.")]
        public string Descricao { get; set; }
        [MaxLength(300, ErrorMessage = "Campo {0} deve conter entre 10 e 300 caracteres.")]
        [MinLength(10, ErrorMessage = "Campo {0} deve conter entre 10 e 300 caracteres.")]
        public string Solucao { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int UserFinishId { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int ChamadoId { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int SubCategoriaId { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int CanalComunicacaoId { get; set; }        
        public string Imagem { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int AmbienteId { get; set; }       
        public string PendenciaImagem { get; set; }
    }
}
