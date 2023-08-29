using System.ComponentModel.DataAnnotations;

namespace DeveloperTest.Repository
{
    public class EntityBase
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
