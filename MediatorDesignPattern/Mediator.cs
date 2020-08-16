using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public abstract class Mediator
    {
        protected readonly IColleague colleagueA;
        protected readonly IColleague colleagueB;

        public Mediator(IColleague colleagueA, IColleague colleagueB)
        {
            this.colleagueA = colleagueA;
            this.colleagueB = colleagueB;
        }

        public abstract void Notify(IColleague sender, string message);
    }
}
