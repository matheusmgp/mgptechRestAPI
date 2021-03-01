using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    [Table("Pendencia")]
    public class Pendencia : BaseEntity
    {
        public string Descricao { get; set; }
        public string? Solucao { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public int? UserFinishId { get; set; }
        [JsonIgnore]
        public User UserFinish { get; set; }
        public int ChamadoId { get; set; }
        [JsonIgnore]
        public Chamado Chamado { get; set; }
        public int CategoriaId { get; set; }
        [JsonIgnore]
        public Categoria Categoria { get; set; }
        public int SubCategoriaId { get; set; }
        [JsonIgnore]
        public SubCategoria SubCategoria { get; set; }
        public int CanalComunicacaoId { get; set; }
        [JsonIgnore]
        public CanalComunicacao CanalComunicacao { get; set; }
        public string? Imagem { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get; set; }
        public string? PendenciaImagem { get; set; }
    }
}