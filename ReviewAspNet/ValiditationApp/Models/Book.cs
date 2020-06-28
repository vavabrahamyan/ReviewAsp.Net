using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValiditationApp.Models
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Book's name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Author of book")]
        [Required]
        public string Author { get; set; }
        [Display(Name = "Create Date")]
        [Required]
        public int Year { get; set; }
    }
}