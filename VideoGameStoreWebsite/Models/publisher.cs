using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameStoreWebsite.Models
{
    public class publisher
    {
        [Key]
        public int publisherId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Website { get; set; }
    }

}