using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Brand")]
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Name is a required field")]
        [StringLength(255)]
        public string Name { get; set; } 
        [StringLength(200)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Status is a required field")]
        public bool Status { get; set; }

        [ForeignKey(nameof(CategoryVehicle))]
        public int CategoryVehicleId { get; set; }
        public CategoryVehicle? CategoryVehicle { get; set; }

        public ICollection<Vehicle>? Vehicles { get; set; }

    }
}
