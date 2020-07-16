using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBigCat lion = new Lion();

            lion.Roar();
            lion.Sprint();

            ICat kitten = new Kitten();

            kitten.Meow();
            kitten.Walk();

            IBigCat catAdapter = new CatAdapter(kitten);

            catAdapter.Roar();
            catAdapter.Sprint();

            Console.ReadLine();
        }
    }
}
