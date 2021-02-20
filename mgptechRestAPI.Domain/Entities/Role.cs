namespace mgptechRestAPI.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Nome { get; set; }
        public int AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}