using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Photos")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is required")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List <Movie>MyProperty { get; set; }

    }
}
