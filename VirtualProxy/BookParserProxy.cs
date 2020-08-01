using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualProxy
{
    public class BookParserProxy : IBookParser
    {
        private IBookParser bookParser = null;
        private readonly string bookContent;

        public BookParserProxy(string bookContent)
        {
            this.bookContent = bookContent;
        }

        // lazy evaluation
        public void ParseBook()
        {
            if (bookParser == null)
            {
                // this is the expensive operation
                bookParser = new BookParser(bookContent);
            }

            bookParser.ParseBook();
        }
    }
}
