﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StrategyPattern
{
    internal class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            WriteLine("<< Silence >>");
        }
    }
}
