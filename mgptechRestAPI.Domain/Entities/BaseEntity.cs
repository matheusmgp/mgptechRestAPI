using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mgptechRestAPI.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("data_cadastro", TypeName = "dateTime2")]
        public DateTime DataCadastro { get; set; }
        [Column("ambiente_id")]
        public int AmbienteId { get; set; }
        [JsonIgnore]
        public Ambiente Ambiente { get; set; }
    }
}