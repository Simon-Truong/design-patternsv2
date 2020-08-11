using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public class FlyweightFactory
    {
        public Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public IFlyweight GetFlyweight(string key)
        {
            string lKey = key.ToLower();

            if (flyweights.TryGetValue(lKey, out IFlyweight flyweight))
            {
                return flyweight;
            }

            IFlyweight newFlyweight = new Flyweight(lKey);

            flyweights.Add(lKey, newFlyweight);
            return newFlyweight;
        }
    }
}
