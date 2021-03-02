using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Chamado")]
    public class Chamado : BaseEntity
    {
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
        [Column("protocolo", TypeName = "varchar(50)")]
        public string Protocolo { get; set; }
        [Column("data_abertura", TypeName = "dateTime2")]       
        public DateTime DataAbertura { get; set; }
        [Column("data_fechamento", TypeName = "dateTime2")]
        public DateTime? DataFechamento { get; set; }

     

        [Column("user_id")]
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; }

        [Column("filial_id")]
        public int FilialId { get; set; }

        [JsonIgnore]
        public Filial Filial { get;  }

        [Column("user_finish_id")]
        public int? UserFinishId { get; set; }

        [JsonIgnore]
        public User UserFinish { get;  }

        [Column("user_redirect_id")]
        public int? UserRedirectId { get; set; }

        [JsonIgnore]
        public User UserRedirect { get; }

        [Column("setor_id")]
        public int SetorId { get; set; }

        [JsonIgnore]
        public Setor Setor { get;  }

        public IEnumerable<Pendencia> Pendencias { get; set; }
    }
}