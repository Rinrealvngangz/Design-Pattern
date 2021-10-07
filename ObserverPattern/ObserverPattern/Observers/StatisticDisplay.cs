using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    internal class StatisticDisplay : IObserver, IDisplayElement
    {
        private float temperature;
   
        private ISubject weatherData;

        public StatisticDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);

        }
        public void display()
        {
            Console.WriteLine(String.Format("Avg/Min/Max temperature = {0}/{1}/{2}", temperature - 1, temperature, temperature + 1));
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            display();
        }
    }
}
