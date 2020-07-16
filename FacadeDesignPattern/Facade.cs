using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class Facade : IFacade
    {
        private readonly Movie _movie;
        private readonly PopcornCooker _popcornCooker;
        private readonly TV _tv;

        public Facade(Movie movie, PopcornCooker popcornCooker, TV tv)
        {
            _movie = movie;
            _popcornCooker = popcornCooker;
            _tv = tv;
        }

        public void FinishMovie()
        {
            _popcornCooker.TurnOff();
            _tv.TurnOff();
        }

        public void PlayMovie()
        {
            _popcornCooker.TurnOn();
            _popcornCooker.CookPopcorn();
            _tv.TurnOn();
            _movie.PlayMovie();
        }
    }
}
