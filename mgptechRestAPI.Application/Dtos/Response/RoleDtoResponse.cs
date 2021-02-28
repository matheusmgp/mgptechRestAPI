using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Dtos.Response
{
    public class RoleDtoResponse : BaseDtoEntity
    {

        public int RoleId { get; set; }
        public string Nome { get; set; }
        public int AmbienteId { get; set; }
    }
}