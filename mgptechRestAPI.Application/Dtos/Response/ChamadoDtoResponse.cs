using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Response
{
    public class ChamadoDtoResponse : BaseDtoEntity
    {
        public string Status { get; set; }
        public string Protocolo { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public int AmbienteId { get; set; }       
        public int UserId { get; set; }
        public int FilialId { get; set; }
        public int UserFinishId { get; set; }
        public int UserRedirectId { get; set; }
        public int SetorId { get; set; }

        public IEnumerable<PendenciaDtoResponse> Pendencias { get; set; }
    }
}
