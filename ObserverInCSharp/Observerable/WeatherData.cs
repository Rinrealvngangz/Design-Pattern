using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    internal class WeatherData : IObservable<Weather>
    {
       List<IObserver<Weather>> observers ;

        public WeatherData()
        {
            observers = new List<IObserver<Weather>>();
        }

        public IDisposable Subscribe(IObserver<Weather> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new UnSubscriber(observers, observer);
         
        }
        private class UnSubscriber : IDisposable
        {
            private List<IObserver<Weather>> _observers;
            private IObserver<Weather> _observer;

            public UnSubscriber(List<IObserver<Weather>> observers, IObserver<Weather> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
               if(_observer is not null && _observers.Contains(_observer) )
                    _observers.Remove(_observer);
            }
        }

        public void TrackWeather(Nullable<Weather> weather)
        {
            foreach (var observer in observers)
            {
                if (! weather.HasValue)
                {
                    observer.OnError(new WeatherUnknownException("Some went wrong"));
                }
                else
                {
                    observer.OnNext(weather.Value);
                }
            }
        }
        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
