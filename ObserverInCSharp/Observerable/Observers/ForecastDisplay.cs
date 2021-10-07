using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable.Observers
{
    internal class ForecastDisplay : IObserver<Weather>
    {
        private IDisposable unsubscriber;
        private string instName;
        public ForecastDisplay(string name)
        {
            this.instName = name;
        }
        public string Name { get { return instName; } }

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
            Console.WriteLine(error);
            Console.WriteLine("{0}: weatherData cannot be determined.", this.Name);
        }

        public virtual void OnNext(Weather value)
        {
            if (value.Temperature > 78.0 && value.Temperature < 85)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (value.Temperature <= 78 && value.Humidity > 10.0)
            {
                Console.WriteLine("Watch for cooler, rainy weather.");
            }
            else if (value.Temperature > 85)
            {
                Console.WriteLine("Watch out!! The next few days are going to be scorchers! ");
            }

        }
        public virtual void Unsubcriber()
        {
            unsubscriber.Dispose();
        }
    }
}
