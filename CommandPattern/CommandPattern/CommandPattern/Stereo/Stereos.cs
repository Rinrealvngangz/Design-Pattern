using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Stereo
{
    internal class Stereos
    {
        private string _name;
        public Stereos(string name)
        {
            this._name = name;  
        }
        public void OnCD() => Console.WriteLine($"{this._name} is on \n " +
                                                $"{this._name} is set fot input\n " +
                                                $"{this._name} volumn set to 11");

        public void OffCD() => Console.WriteLine($"{this._name} is off");
    }
}
