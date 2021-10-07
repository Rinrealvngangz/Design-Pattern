using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ObserverPattern
{
    internal class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers =new ArrayList();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void unregisterObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if(i >= 0) observers.RemoveAt(i);
        }

        public void notifyObserver()
        {
            for(int i =0; i < observers.Count; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.update(temperature,humidity,pressure);

            }
        }
        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature , float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

    }
}
