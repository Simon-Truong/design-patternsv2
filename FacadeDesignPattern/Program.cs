using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            PopcornCooker popcornCooker = new PopcornCooker();
            TV tv = new TV();

            IFacade facade = new Facade(movie, popcornCooker, tv);

            facade.PlayMovie();
            facade.FinishMovie();

            Console.ReadLine();
        }
    }
}
