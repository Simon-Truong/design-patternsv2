using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace ObserverDesignPattern
{
    public class John : IObserver
    {
        private readonly string name = "John";
        private readonly ISubject _subject;
        private string breakingNews;

        public John(ISubject subject)
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
