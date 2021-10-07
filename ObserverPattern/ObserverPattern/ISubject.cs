using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface ISubject
    {
        public void registerObserver(IObserver o);
        public void unregisterObserver(IObserver o);
        public void notifyObserver();

    }
}
