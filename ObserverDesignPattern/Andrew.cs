using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class Andrew : IObserver
    {
        private readonly string name = "Andrew";
        private readonly ISubject _subject;
        private string breakingNews;

        public Andrew(ISubject subject)
        {
            _subject = subject;
            _subject.AddObserver(this);
        }

        public void Notify(string breakingNews)
        {
            this.breakingNews = breakingNews;
            ReadNews();
        }

        public void ReadNews()
        {
            Console.WriteLine($"{name} is reading \"{breakingNews}\"");
        }
    }
}
