namespace mgptechRestAPI.Application.Dtos.Response
{
    public class SubCategoriaDtoResponse : BaseDtoEntity
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public int CategoriaId { get; set; }
        public int AmbienteId { get; set; }
    }
}