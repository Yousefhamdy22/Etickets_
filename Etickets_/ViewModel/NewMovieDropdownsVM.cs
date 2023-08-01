using System.Collections.Generic;
using Etickets_.Models;

namespace Etickets_.ViewModel.Model
{
    public class NewMovieDropdownsVM
    {

        public NewMovieDropdownsVM()
        {
            Producers = new List<producer>();
            Cinemas = new List<Cinema>();
            Actors= new List<Actor>();
        }



        public List<producer> Producers { get; set; }
        public List <Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }


    }
}
