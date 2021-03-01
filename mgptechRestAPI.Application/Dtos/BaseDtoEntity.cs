using System;

namespace mgptechRestAPI.Application.Dtos
{
    public abstract class BaseDtoEntity
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}