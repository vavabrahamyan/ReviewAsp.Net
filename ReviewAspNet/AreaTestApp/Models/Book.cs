using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AreaTestApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Book's name")]
        public string Name { get; set; }
        [Display(Name = "Author of book")]
        public string Author { get; set; }
        [Display(Name = "Create Date")]
        public int  Year { get; set; }
    }
}