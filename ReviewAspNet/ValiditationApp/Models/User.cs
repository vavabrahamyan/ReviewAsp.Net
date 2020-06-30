using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValiditationApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name ="User_Name")]
        [Required(ErrorMessage ="The field can't be empty")]
        public string Name { get; set; }
        [StringLength(15, MinimumLength =4, ErrorMessage = "Length isn't currectly")]
        public string Surname { get; set; }
    }
}