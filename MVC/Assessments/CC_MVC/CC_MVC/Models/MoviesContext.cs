using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CC_MVC.Models
{
    public class MoviesContext:DbContext
    {
        public MoviesContext() : base("connectstr")
        { }

        public DbSet<Movie> Movies { get; set; }
    }
}