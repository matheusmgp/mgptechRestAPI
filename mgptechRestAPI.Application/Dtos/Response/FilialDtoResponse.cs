namespace mgptechRestAPI.Application.Dtos.Response
{
    public class FilialDtoResponse : BaseDtoEntity
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Status { get; set; }
        public string NomeFantasia { get; set; }
        public int AmbienteId { get; set; }
    }
}