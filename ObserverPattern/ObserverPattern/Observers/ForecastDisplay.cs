using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    internal class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;
        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }
        public void display()
        {
            if (temperature > 78.0 && temperature < 85)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (temperature <= 78 && humidity > 10.0)
            {
                Console.WriteLine("Watch for cooler, rainy weather.");
            }
            else if (temperature > 85)
            {
                Console.WriteLine("Watch out!! The next few days are going to be scorchers! ");
            }

        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
    }
}
