using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.GarageDoor.GarageDoorCommand
{
    internal class DownGarageDoorLight : ICommand
    {
        GarageDoor _garageDoor;
        public DownGarageDoorLight(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void execute()
        {
            this._garageDoor.Down();
        }

        public void undo()
        {
            this._garageDoor.Up();
        }
    }
}
