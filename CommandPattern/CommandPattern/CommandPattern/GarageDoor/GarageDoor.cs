using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.GarageDoor
{
    internal class GarageDoor
    {
        private string _name;
        public GarageDoor(string name)
        {
            this._name = name;
        }
        public void Up() => Console.WriteLine($"{this._name} is Up.");
        public void Down() => Console.WriteLine($"{this._name} is Down.");
    }
}
