namespace mgptechRestAPI.Application.Dtos.Response
{
    public class CategoriaDtoResponse : BaseDtoEntity
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public int AmbienteId { get; set; }
    }
}