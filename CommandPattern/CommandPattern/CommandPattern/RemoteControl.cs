using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class RemoteControl
    {
        ICommand[] _onCommand;
        ICommand[] _offCommand;
        ICommand undoCommand;
        public RemoteControl()
        {
            _onCommand = new ICommand[7];
            _offCommand = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommand[i] = noCommand;
                _offCommand[i] = noCommand;
            }
            undoCommand = noCommand;

        }
        public void setCommand(int slot,ICommand onCommand,ICommand offCommand)
        {
            _onCommand[slot] = onCommand;
            _offCommand[slot] = offCommand;

        }

        public void onButtonWasPressed(int slot)
        {
            _onCommand[slot].execute();
            undoCommand = _onCommand[slot];
        }

        public void offButtonWasPressed(int slot)
        {
            _offCommand[slot].execute();
            undoCommand = _offCommand[slot];
        }
        public void undoButtonWasPressed()
        {
            undoCommand.undo();
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n--------Remote Control-----------\n");
            for (int i = 0; i < _onCommand.Length; i++)
            {
                sb.Append("[slot " + i + "] " +
                          _onCommand[i].GetType().Name + "   " +
                          _offCommand[i].GetType().Name);
            }
            return sb.ToString();
        }
    }
}
