using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    internal class CurrentConditionsDisplay : IObserver,IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " +temperature + " F degrees and "+ humidity + "% humidity");
        }

        public void update(float temp, float humidity, float pressure)     
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
            
        }
     }

}
