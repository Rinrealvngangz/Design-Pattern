using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Stereo.StereoCommand
{
    internal class StereoOffCommand : ICommand
    {
        Stereos _stereo;
        public StereoOffCommand(Stereos stereo)
        {
            this._stereo = stereo;
        }
        public void execute()
        {
            this._stereo.OffCD();
        }

        public void undo()
        {
            this._stereo.OnCD();
        }
    }
}
