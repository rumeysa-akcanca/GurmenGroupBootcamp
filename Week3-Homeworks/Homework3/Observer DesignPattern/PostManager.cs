using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DesignPattern
{
    public class PostManager
    {
        private List<Observer> _observers = new List<Observer>();
        public void UpdatePost()
        {
            Console.WriteLine("Post details is changed ");
        }
        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }
        public void DeleteObserver(Observer observer)
        {
            _observers.Remove(observer);
        }
        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
