using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("TypeDocument")]
    public class TypeDocument
    {
        [Key]
        [Required(ErrorMessage = "Type is a required field")]
        public string Type { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage ="Description is a required field")]
        public string Description { get; set; }
        public bool Status { get; set; }

        public ICollection<Client>? Clients { get; set; }
        public ICollection<User>? Users { get; set; }

       


    }
}
