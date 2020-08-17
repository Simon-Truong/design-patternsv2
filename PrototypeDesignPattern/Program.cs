using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person();

            personA.Name = "Will";
            personA.Age = 31;

            personA.Address = new Address
            {
                Number = 1,
                Street = "Fountain Street",
                Suburb = "Tie"
            };

            Console.WriteLine(personA.Name);
            Console.WriteLine(personA.Age);
            Console.WriteLine(personA.Address.Number);
            Console.WriteLine(personA.Address.Street);
            Console.WriteLine(personA.Address.Suburb);

            Person personB = personA.ShallowClone();

            personB.Name = "William";
            personB.Age = 13;

            //personB.Address.Number = 2;

            //Console.WriteLine("===");

            //Console.WriteLine(personB.Name);
            //Console.WriteLine(personB.Age);
            //Console.WriteLine(personB.Address.Number);
            //Console.WriteLine(personB.Address.Street);
            //Console.WriteLine(personB.Address.Suburb);

            //Console.WriteLine("===");

            //Console.WriteLine(personA.Name);
            //Console.WriteLine(personA.Age);
            //Console.WriteLine(personA.Address.Number);
            //Console.WriteLine(personA.Address.Street);
            //Console.WriteLine(personA.Address.Suburb);

            personB.Address = personB.Address.ShallowClone();

            personB.Address.Number = 46;
            personB.Address.Street = "Roger Street";
            personB.Address.Suburb = "Field";

            Console.WriteLine("===");

            Console.WriteLine(personB.Name);
            Console.WriteLine(personB.Age);
            Console.WriteLine(personB.Address.Number);
            Console.WriteLine(personB.Address.Street);
            Console.WriteLine(personB.Address.Suburb);

            Console.WriteLine("===");

            Console.WriteLine(personA.Name);
            Console.WriteLine(personA.Age);
            Console.WriteLine(personA.Address.Number);
            Console.WriteLine(personA.Address.Street);
            Console.WriteLine(personA.Address.Suburb);

            Console.ReadLine();
        }
    }
}
