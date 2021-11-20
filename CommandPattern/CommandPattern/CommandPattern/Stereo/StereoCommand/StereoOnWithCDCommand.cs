using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Stereo.StereoCommand
{
    internal class StereoOnWithCDCommand :ICommand
    {
        Stereos _stereo;
        public StereoOnWithCDCommand(Stereos stereo)
        {
            this._stereo = stereo;
        }
        public void execute()
        {
            this._stereo.OnCD();
        }
        public void undo()
        {
            this._stereo.OffCD();
        }
    }
}
