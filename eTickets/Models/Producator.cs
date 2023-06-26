using eFarm.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eFarm.Models
{
    public class Producator:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Producator Logo")]
        [Required(ErrorMessage = "Producator logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Producator Name")]
        [Required(ErrorMessage = "Producator name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Producator description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
