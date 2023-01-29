using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Repair")]
    public class Repair
    {
        [Key]
        public int RepairId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        [Required(ErrorMessage = "This field is required")]
        public decimal Subtotal { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        [Required(ErrorMessage = "This field is required")]
        public decimal Total { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(User))]
        public int DocumentNumU { get; set; }
        public User? User { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public string Plate { get; set; }
        public Vehicle? Vehicle{ get; set; }

    }
}
