using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Pug : IPet
    {
        private readonly string _name;

        public Pug(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public string Type => "Pug";
    }
}
