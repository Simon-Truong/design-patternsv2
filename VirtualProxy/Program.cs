using System;

namespace VirtualProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookParser bookParser = new BookParserProxy("Book content");
            bookParser.ParseBook();

            Console.ReadLine();
        }
    }
}
