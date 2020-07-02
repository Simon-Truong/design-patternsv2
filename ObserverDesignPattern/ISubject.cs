using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public interface ISubject
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();
        public void UpdateBreakingNews();
    }
}
