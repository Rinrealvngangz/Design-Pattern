using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.CeilingFan.CeilingCommand
{
    internal class CeilingFanOn :ICommand
    {
        CeilingFans _ceilingFan;
        public CeilingFanOn(CeilingFans ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void execute()
        {
            this._ceilingFan.On();
        }

        public void undo()
        {
            this._ceilingFan.Off();
        }
    }
}
