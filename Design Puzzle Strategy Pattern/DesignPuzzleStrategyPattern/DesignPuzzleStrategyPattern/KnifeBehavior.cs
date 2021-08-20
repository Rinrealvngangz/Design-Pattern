using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPuzzleStrategyPattern
{
    class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using knife");
        }
    }
}
