using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAMovieApp.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage="Please enter a title")]
        public string Title { get; set; }
        [StringLength(10, ErrorMessage = "The director cannot be more than 10 characters ")]
        public string Director { get; set; }
        public string ImageUrl { get; set; }
    }
}