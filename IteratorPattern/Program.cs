using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPet pug1 = new Pug("Rusty");
            IPet pug2 = new Pug("Snowball");

            IPet frenchie1 = new FrenchBullDog("Boi");
            IPet frenchie2 = new FrenchBullDog("Guy");

            IPetStore petStore1 = new PetStore(new IPet[] { pug1, frenchie1 });
            IPetStore petStore2 = new PetStoreCompetitor(new Dictionary<string, IPet> { { "testing", pug2 }, { "testing1", frenchie2 } });

            IIterator iterator1 = petStore1.CreateIterator();
            IIterator iterator2 = petStore2.CreateIterator();

            List<IIterator> iteratorCollection = new List<IIterator>();
            iteratorCollection.Add(iterator1);
            iteratorCollection.Add(iterator2);

            Print(iteratorCollection);

            Console.ReadLine();
        }

        private static void Print(IEnumerable<IIterator> iteratorCollection)
        {
            foreach (IIterator iterator in iteratorCollection)
            {
                while (iterator.HasNext())
                {
                    IPet pet = iterator.Next();
                    Console.WriteLine($"{pet.Name} - {pet.Type}");
                }
            }
        }
    }
}
