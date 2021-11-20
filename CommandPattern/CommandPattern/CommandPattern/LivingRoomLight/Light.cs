using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.LivingRoomLight
{
    internal class Light
    {
        private string _name;
        public Light(string name)
        {
            this._name = name;
        }
        public void On() => Console.WriteLine($"{this._name} light is on");


        public void Off() => Console.WriteLine($"{this._name} light is off");
    }
}
