using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualProxy
{
    public class BookParser : IBookParser
    {
        private readonly string bookContent;

        public BookParser(string bookContent)
        {
            // very expensive operation
            this.bookContent = bookContent;
        }

        public void ParseBook()
        {
            Console.WriteLine("Parsing Book");
        }
    }
}
