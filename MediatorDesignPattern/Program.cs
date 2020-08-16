using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IColleague colleagueA = new ConcreteColleague("A");
            IColleague colleagueB = new ConcreteColleague("B");

            Mediator mediator = new ConcreteMediator(colleagueA, colleagueB);

            mediator.Notify(colleagueA, "Hi colleagueB");
            mediator.Notify(colleagueB, "Hi colleagueA");
        }
    }
}
