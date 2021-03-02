using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Pendencia")]
    public class Pendencia : BaseEntity
    {
        [Column("descricao", TypeName = "text")]
        public string Descricao { get; set; }
        [Column("solucao", TypeName = "text")]
        public string? Solucao { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get;  }
        [Column("user_finish_id")]
        public int? UserFinishId { get; set; }
        [JsonIgnore]
        public User UserFinish { get; set; }
        [Column("chamado_id")]
        public int ChamadoId { get; set; }
        [JsonIgnore]
        public Chamado Chamado { get; }
        [Column("categoria_id")]
        public int CategoriaId { get; set; }
        [JsonIgnore]
        public Categoria Categoria { get;  }
        [Column("subCategoria_id")]
        public int SubCategoriaId { get; set; }
        [JsonIgnore]
        public SubCategoria SubCategoria { get; }
        [Column("canal_id")]
        public int CanalComunicacaoId { get; set; }
        [JsonIgnore]
        public CanalComunicacao CanalComunicacao { get; }
        [Column("imagem", TypeName = "varchar(200)")]
        public string? Imagem { get; set; }
        [Column("status", TypeName = "varchar(1)")]
        public string Status { get; set; }
        [Column("data_abertura", TypeName = "dateTime2")]
        public DateTime DataAbertura { get; set; }
        [Column("data_fechamento", TypeName = "dateTime2")]
        public DateTime? DataFechamento { get; set; }
      
        [Column("pendencia_imagem", TypeName = "varchar(50)")]
        public string? PendenciaImagem { get; set; }
    }
}