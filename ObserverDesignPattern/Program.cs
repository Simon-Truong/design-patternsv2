using System;
using System.Dynamic;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject newsPaperPublisher = new NewsPaperPublisher();
            IObserver subscriberA = new John(newsPaperPublisher);
            IObserver subscriberB = new Andrew(newsPaperPublisher);

            newsPaperPublisher.UpdateBreakingNews();
            newsPaperPublisher.RemoveObserver(subscriberA);
            newsPaperPublisher.UpdateBreakingNews();

            /**
             * note we can also do a pull method for the observer pattern
             * this can be done by sending a reference of the subject to the observer where the subject has state
             * implement getters in the subject and the observer can get state by these getters methods
             */

            Console.ReadLine();
        }
    }
}
