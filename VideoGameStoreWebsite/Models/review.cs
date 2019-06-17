using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace VideoGameStoreWebsite.Models
{
    public class review
    {
        [Key]
        public int developerId { get; set; }
        [Required]
        [Display(Name = "dName")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required]
        [Display(Name = "Discription")]
        public string Description { get; set; }
        [Required]
        [Range(1, 5)]
        [Display(Name = "Stars")]
        public int number_of_Stars { get; set; }
    }

}