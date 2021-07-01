using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wycieczki.Interfaces
{
    public interface IObservable<T>
    {
        public void Subscribe(T observer);
        public void Unsubscribe(T observer);
        public void Notify();
    }
}
