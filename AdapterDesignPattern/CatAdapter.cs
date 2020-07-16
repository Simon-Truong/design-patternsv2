using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    public class CatAdapter : IBigCat
    {
        private readonly ICat _cat;

        public CatAdapter(ICat cat)
        {
            _cat = cat;
        }

        public void Roar()
        {
            _cat.Meow();
        }

        public void Sprint()
        {
            _cat.Walk();
        }
    }
}
