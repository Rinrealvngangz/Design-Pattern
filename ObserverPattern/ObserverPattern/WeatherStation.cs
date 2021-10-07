using System;
using ObserverPattern.Observers;
namespace ObserverPattern
{
    class WeatherStation
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Weather Station");
            Console.WriteLine();
            WeatherData weatherData= new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay= new CurrentConditionsDisplay(weatherData);
            StatisticDisplay statisticDisplay= new StatisticDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            weatherData.setMeasurements(80,65,30.4f);
            Console.WriteLine();
            weatherData.setMeasurements(72, 60, 20.2f);
            Console.WriteLine();
            weatherData.setMeasurements(40, 56, 29.6f);
            Console.WriteLine();
          
           

        }

    }
}