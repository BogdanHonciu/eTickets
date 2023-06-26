using eFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFarm.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Couriers = new List<Courier>();
            Producatori = new List<Producator>();
            Actors = new List<Actor>();
        }

        public List<Courier> Couriers { get; set; }
        public List<Producator> Producatori { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
