using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.LivingRoomLight.LightCommand
{
    internal class LightOnCommand : ICommand
    {
        Light _light;
        public LightOnCommand(Light light)
        {
            this._light = light;
        }
        public void execute()
         {
            this._light.On();
         }

        public void undo()
        {
            this._light.Off();
        }
    }
}
