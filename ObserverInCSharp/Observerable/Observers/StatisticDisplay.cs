using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable.Observers
{
    internal class StatisticDisplay :  IObserver<Weather>
    {
        private IDisposable unsubscriber;
        private string instName;
        public StatisticDisplay(string name)
        {
            this.instName = name;  
        }

        public string Name { get { return instName; }  }
        public virtual void Subscribe(IObservable<Weather> provider)
        {
            if (provider is not null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("WeatherData Tracker has completed transmitting data to {0}.", this.Name);
            this.Unsubcriber();
        }

        public virtual void OnError(Exception error)
        {
            Console.WriteLine("{0}: weatherData cannot be determined.", this.Name);
        }

        public virtual void OnNext(Weather value)
        {
            Console.WriteLine(String.Format("Avg/Min/Max temperature = {0}/{1}/{2}", value.Temperature - 1, value.Temperature, value.Temperature + 1));

        }
        public virtual void Unsubcriber()
        {
            unsubscriber.Dispose();
        }
    }
}
