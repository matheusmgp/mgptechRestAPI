using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Dtos.Response
{
    public class RoleDtoResponse : BaseEntity
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int AmbienteId { get; set; }
    }
}