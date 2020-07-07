using ModelBinderApp.Binders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinderApp.Models
{
    [ModelBinder(typeof(BookModelBinder))]
    public class Book
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ay ay ay")]
        [Display(Name = "Book_Name")]
        public string Name { get; set; }
        [Required]
        public string Author  { get; set; }
        public int Year { get; set; }
    }
}