using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Viedly2.Models;

namespace Viedly2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customers> Customers { get; set; }
    }
}