using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable.Observers
{
    internal class CurrentConditionsDisplay : IObserver<Weather>
    {
        private IDisposable unsubscriber;
        private string instName;

        public CurrentConditionsDisplay(string name)
        {
            this.instName = name; 
        }

        public string Name { get {  return this.instName; } }

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
            Console.WriteLine("{0}: " + value.Temperature + " F degrees and " + value.Humidity + "% humidity.",this.Name);

        }
        public virtual void Unsubcriber()
        {
            unsubscriber.Dispose();
        }
    }
}
