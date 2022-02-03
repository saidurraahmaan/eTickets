using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class NewMovieDropDownsVM
    {
        public List <Producer> Producers { get; set; }
        public List <Cinema>Cinemas { get; set; }
        public List <Actor>Actors { get; set; }
        public NewMovieDropDownsVM()
        {
            Producers = new List<Producer>();
            Producers = new List<Producer>();
            Producers = new List<Producer>();
        }
    }
}
