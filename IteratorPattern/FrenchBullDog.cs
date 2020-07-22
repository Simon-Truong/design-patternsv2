using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class FrenchBullDog : IPet
    {
        public readonly string _name;

        public FrenchBullDog(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public string Type => "French Bull Dog";
    }
}
