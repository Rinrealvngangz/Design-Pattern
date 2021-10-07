using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    internal class WeatherUnknownException :Exception
    {
        internal WeatherUnknownException(string message) : base(message)
        {

        }
    }
}
