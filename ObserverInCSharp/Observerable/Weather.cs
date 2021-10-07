using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    internal struct Weather
    {
        private float temp;
        private float humidity;
        private float pressure;
        public Weather(float temp , float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public float Temperature { get {return temp;} }
        public float Humidity {  get { return humidity;} }
        public float Pressure {  get {  return pressure;} }

    }
}
