using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        [StringLength(255)]
        public string Plate { get; set; } 

        [Required(ErrorMessage = "Color is a required field")]
        [StringLength(255)]
        public string Color { get; set; } 
  
        [StringLength(255)]
        public string? Mileage { get; set; }
        [StringLength(255)]
        public string? ModelYear { get; set; }

        [ForeignKey(nameof(StatusVehicle))]
        public int StatusVehicleId { get; set; }

        public StatusVehicle? StatusVehicle { get; set; }

        [ForeignKey(nameof(Brand))]
        public int BrandId { get; set; }

        public Brand? Brand { get; set; }
        public Client? Client { get; set; }


       
    }
}
