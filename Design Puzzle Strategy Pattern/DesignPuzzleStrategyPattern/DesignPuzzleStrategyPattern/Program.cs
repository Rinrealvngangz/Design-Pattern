using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPuzzleStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running game....");

            var king = new King();
            king.Display();
            king.fight();
            king.SetWeapon(new KnifeBehavior());
            king.fight();

            var queen = new Queen();
            queen.Display();
            queen.SetWeapon(new BowAndArrowBehavior());
            queen.fight();
            Console.ReadKey();
        }
    }
}
