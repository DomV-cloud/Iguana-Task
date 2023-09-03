using DeveloperTest.Repository;
using System.ComponentModel.DataAnnotations;

namespace DeveloperTest.Models
{
    public class Invoice: EntityBase
    {

        [Required]
        public int Invoice_Number{ get; set; }


        public bool IsPaid { get; set; } = false;

    }
}
