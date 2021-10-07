using System;
using Observable.Observers;
namespace Observable
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station");
            Console.WriteLine();
            WeatherData provider= new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay= new CurrentConditionsDisplay(nameof(CurrentConditionsDisplay));
            currentConditionsDisplay.Subscribe(provider);

            StatisticDisplay statisticDisplay = new StatisticDisplay(nameof(StatisticDisplay));
            statisticDisplay.Subscribe(provider);

            ForecastDisplay forecastDisplay = new ForecastDisplay(nameof(ForecastDisplay));
            forecastDisplay.Subscribe(provider);

            provider.TrackWeather(new Weather(20,65,37.4f));
            provider.TrackWeather(new Weather(30, 25, 29.2f));
            provider.TrackWeather(new Weather(10, 45, 40.8f));
            provider.TrackWeather(null);


            currentConditionsDisplay.Unsubcriber();
            statisticDisplay.Unsubcriber();
            provider.EndTransmission();


        }

    }
}