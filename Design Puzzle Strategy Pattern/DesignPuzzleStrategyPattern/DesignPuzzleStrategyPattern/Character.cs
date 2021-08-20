using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPuzzleStrategyPattern
{
   public abstract class Character
    {
        public IWeaponBehavior _w;
        public void SetWeapon(IWeaponBehavior w)
        {
            _w = w;
        }
       public void fight()
        {
            _w.UseWeapon();
        }

      public abstract void Display();


    }
}
