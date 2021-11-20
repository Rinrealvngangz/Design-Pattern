using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class NoCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("No Command");
        }

        public void undo()
        {
            throw new NotImplementedException();
        }
    }
}
