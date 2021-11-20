using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.CeilingFan.CeilingCommand
{
    internal class CeilingFanOff : ICommand
    {
        CeilingFans _ceilingFan;
        public CeilingFanOff(CeilingFans ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void execute()
        {
            this._ceilingFan.Off();
        }

        public void undo()
        {
            this._ceilingFan.On();
        }
    }
}
