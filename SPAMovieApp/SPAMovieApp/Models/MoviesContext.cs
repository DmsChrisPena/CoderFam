using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPAMovieApp.Models
{
    public class MoviesContext : DbContext
    {
        public IDbSet<Movies> Movies { get; set; }
    }
}