using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.GarageDoor.GarageDoorCommand
{
    internal class UpGarageDoorLight :ICommand
    {
        GarageDoor _garageDoor;
        public UpGarageDoorLight(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void execute()
        {
            this._garageDoor.Up();
        }
        public void undo()
        {
            this._garageDoor.Down();
        }
    }
}
