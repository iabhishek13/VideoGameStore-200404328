using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameStoreWebsite.Models
{
    public class game
    {
        [Key]
        public int gameId { get; set; }
        [Required]
        [Display(Name = "Game Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Game Price")]
        public int price { get; set; }
        [Required]
        [Display(Name = "Game Description")]
        public string description { get; set; }
        [Required]
        [Display(Name = "Game Requirements")]
        public string minimumRequirements { get; set; }
        [Required]
        [Display(Name = "Game Publisher")]
        public string publisher { get; set; }
        [Required]
        [Display(Name = "Game Developer")]
        public string developer { get; set; }
        [Required]
        [Display(Name = "Game Genre")]
        public string genre { get; set; }
        [Required]
        [Range(1, 5)]
        [Display(Name = "Game Reviews")]
        public int reviews { get; set; }
    }

}