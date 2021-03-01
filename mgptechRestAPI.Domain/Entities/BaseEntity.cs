using System;
using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}