using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Response
{
    public class PendenciaDtoResponse : BaseDtoEntity
    {
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public int UserId { get; set; }
        
        public int UserFinishId { get; set; }
       
        public int ChamadoId { get; set; }

        public ChamadoDtoResponse Chamado { get; set; }

        public int CategoriaId { get; set; }
        
        public int SubCategoriaId { get; set; }
       
        public int CanalComunicacaoId { get; set; }
        
        public string Imagem { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public int AmbienteId { get; set; }
        
        public string PendenciaImagem { get; set; }
    }
}
