using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Chamado")]
    public class Chamado : BaseEntity
    {
        public string Status { get; set; }
        public string Protocolo { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }

        public int AmbienteId { get; set; }

        [JsonIgnore]
        public Ambiente Ambiente { get; set; }

        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public int FilialId { get; set; }

        [JsonIgnore]
        public Filial Filial { get; set; }

        public int? UserFinishId { get; set; }

        [JsonIgnore]
        public User UserFinish { get; set; }

        public int? UserRedirectId { get; set; }

        [JsonIgnore]
        public User UserRedirect { get; set; }

        public int SetorId { get; set; }

        [JsonIgnore]
        public Setor Setor { get; set; }

        public IEnumerable<Pendencia> Pendencias { get; set; }
    }
}