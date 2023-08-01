using Etickets_.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Etickets_.Models
{
    public class Actor: IEntityBase
    {

        [Key]
        public int Id { get; set; }
        [Display(Name =" Profile Piciture URL")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string Profilepicitureurl { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        // Reltion
        public List<Actor_MOvie> Actors_Movies { get; set; }


    }
}
