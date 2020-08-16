using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteMediator(IColleague colleagueA, IColleague colleagueB) : base(colleagueA, colleagueB)
        {
        }

        public override void Notify(IColleague sender, string message)
        {
            if (sender == colleagueA)
            {
                colleagueB.Receive(message);
            }

            if (sender == colleagueA)
            {
                colleagueA.Receive(message);
            }
        }
    }
}
