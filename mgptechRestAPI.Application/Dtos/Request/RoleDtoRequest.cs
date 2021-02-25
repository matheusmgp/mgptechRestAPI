using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Dtos.Request
{
    public class RoleDtoRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AmbienteId { get; set; }
    }
}
