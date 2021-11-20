using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.CeilingFan
{
    internal class CeilingFans
    {
        private string _name;
        public CeilingFans(string name)
        {
            this._name = name;
        }
        public void On() => Console.WriteLine($"{_name} fan is On");
        public void Off() => Console.WriteLine($"{_name} fan is Off");
    }
}
