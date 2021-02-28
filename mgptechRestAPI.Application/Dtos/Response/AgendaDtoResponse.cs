﻿namespace mgptechRestAPI.Application.Dtos.Response
{
    public class AgendaDtoResponse : BaseDtoEntity
    {
       

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string? Observacao { get; set; }

        public int AmbienteId { get; set; }
    }
}