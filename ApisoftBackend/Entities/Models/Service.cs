using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Services")]
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage ="Name Service field is required")]
        public string Name { get; set; }        
        public string? Description { get; set; }
        [Required(ErrorMessage = "Status Service field is required")]
        public bool Status { get; set; }

        public ICollection<RepairService>? RepairsServices { get; set; }
    }
}
