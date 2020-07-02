using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class NewsPaperPublisher : ISubject
    {
        private readonly List<IObserver> _observers;
        private string breakingNews;

        public NewsPaperPublisher()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = _observers.IndexOf(observer);
            _observers.RemoveAt(index);
        }

        public void UpdateBreakingNews()
        {
            breakingNews = "Man stepped on the moon";
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Notify(breakingNews);
            }
        }
    }
}
