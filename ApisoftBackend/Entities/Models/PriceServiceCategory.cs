using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("PriceServiceCategory")]
    public  class PriceServiceCategory
    {
      
        [Key]
        public int PriceServiceCategoryId { get; set; }

        [Required(ErrorMessage = "Price is required Field")]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; }

        [ForeignKey(nameof(CategoryVehicle))]
        public int CategoryVehicleId { get; set; }
        public bool Status { get; set; }

        public CategoryVehicle? CategoryVehicle { get; set; }


        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }

        public Service? Service { get; set; }





    }
}
