using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialSebastianFerrufino.Models
{
    public class Country
    {
        [Key]
        [Required]
        public string AlphaCode3 { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        [Display(Name = "Nombre del Pais")]
        public string Name { get; set; }

        [Required]
        public double Area { get; set; }

        [Required]
        public int CallingCodes { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        [RegularExpression(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$")]
        public string Flag { get; set; }

    }
}