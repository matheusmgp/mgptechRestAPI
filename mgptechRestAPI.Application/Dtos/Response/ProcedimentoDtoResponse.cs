namespace mgptechRestAPI.Application.Dtos.Response
{
    public class ProcedimentoDtoResponse : BaseDtoEntity
    {
        public string DescricaoValue { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public int AmbienteId { get; set; }
    }
}