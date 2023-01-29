using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("StatusVehicle")]
    public class StatusVehicle
    {
        [Key]
        public int StatusVehicleId { get; set; }
        [Required(ErrorMessage = "Name is a required field")]
        [StringLength(255)]
        public string Name { get; set; } 
        [Column(TypeName = "text")]
        public string? Description { get; set; }
        public bool Status { get; set; }

        public ICollection<Vehicle>? Vehicles { get; set; }



    }
}
