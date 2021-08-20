using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPuzzleStrategyPattern
{
   public class King : Character
    {
        public King()
        {
            _w = new AxeBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("I'm king");
        }
    }
}
