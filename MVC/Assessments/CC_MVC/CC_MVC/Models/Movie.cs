using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CC_MVC.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }
        public string Moviename { get; set; }
        public DateTime DateofRelease { get; set; }
    }
}