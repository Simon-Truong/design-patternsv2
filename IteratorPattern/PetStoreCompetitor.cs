using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    public class PetStoreCompetitor : IPetStore
    {
        private readonly Dictionary<string, IPet> _pets;

        public PetStoreCompetitor(Dictionary<string, IPet> pets)
        {
            _pets = pets;
        }

        public IIterator CreateIterator()
        {
            return new PetStoreIterator(_pets.Values.ToArray());
        }

        // this is now redundant
        //public Dictionary<string, IPet> GetPets()
        //{
        //    return _pets;
        //}
    }
}
