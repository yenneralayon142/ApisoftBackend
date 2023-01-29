using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Document number is a required field")]
        public int DocumentNumU { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "First Name is a required field")]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string? SecondName { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "First Surname is a required field")]
        public string FirstSurname { get; set; } 
        [StringLength(255)]
        public string? SecondSurname { get; set; }
        [StringLength(255)]        
        public string? Direction { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Number Phone is a required field")]
        public string Phone { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(TypeDocument))]
        public string Type { get; set; }
        public TypeDocument? TypeDocument { get; set; }

        public ICollection<Repair>? Repairs { get; set; }
    }
}
