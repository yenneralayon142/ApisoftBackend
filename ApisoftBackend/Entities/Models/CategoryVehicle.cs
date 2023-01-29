using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("CategoryVehicle")]
    public class CategoryVehicle
    {
    
        [Key]
        public int CategoryVehicleId { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Name is a required field")]
        public string Name { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
        public bool Status { get; set; }

        public ICollection<Brand>? Brands { get; set; }


    }
}
