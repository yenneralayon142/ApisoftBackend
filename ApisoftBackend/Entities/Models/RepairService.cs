using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("RepairService")]
    public class RepairService
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public Service? Service { get; set; }


        [ForeignKey(nameof(Repair))]
        public int RepairId { get; set; }
        public Repair? Repair { get; set; }


        [ForeignKey(nameof(PriceServiceCategory))]
        public int PriceServiceCategoryId { get; set; }
        public PriceServiceCategory? PriceServiceCategory { get; set; }


    }
}
