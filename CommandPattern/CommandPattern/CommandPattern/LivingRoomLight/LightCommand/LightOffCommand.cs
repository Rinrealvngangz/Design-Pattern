using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.LivingRoomLight.LightCommand
{
    internal class LightOffCommand : ICommand
    {
        Light _light;
        public LightOffCommand(Light light)
        {
            this._light = light;
        }

        public void execute()
        {
            this._light.Off();
        }

        public void undo()
        {
            this._light.On();
        }
    }
}
