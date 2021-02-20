using System.ComponentModel.DataAnnotations;

namespace mgptechRestAPI.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
