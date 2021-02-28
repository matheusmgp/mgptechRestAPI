namespace mgptechRestAPI.Application.Dtos.Response
{
    public class SetorDtoResponse : BaseDtoEntity
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public string Tempo { get; set; }
        public string TempoRapido { get; set; }
        public string TempoMedio { get; set; }
        public int AmbienteId { get; set; }
    }
}