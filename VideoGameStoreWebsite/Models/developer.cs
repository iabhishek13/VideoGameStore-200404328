using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameStoreWebsite.Models
{
    public class developer
    {
        [Key]
        public int developerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Website { get; set; }
    }

}