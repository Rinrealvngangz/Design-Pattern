using System;
using CommandPattern.LivingRoomLight;
using CommandPattern.LivingRoomLight.LightCommand;
using CommandPattern.CeilingFan;
using CommandPattern.CeilingFan.CeilingCommand;
using CommandPattern.GarageDoor;
using CommandPattern.GarageDoor.GarageDoorCommand;
using CommandPattern.Stereo;
using CommandPattern.Stereo.StereoCommand;
namespace CommandPattern
{
    public class RemoteLoader
    {
        public static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light light = new Light("Living Room");
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            Light kitChenlight = new Light("KitChen");
            LightOnCommand kitChenlightOn = new LightOnCommand(kitChenlight);
            LightOffCommand kitChenlightOff = new LightOffCommand(kitChenlight);

            CeilingFans ceilingFan = new CeilingFans("Ceiling fan");
            CeilingFanOn ceilingFanOn =new CeilingFanOn(ceilingFan);
            CeilingFanOff ceilingFanOff = new CeilingFanOff(ceilingFan);

            Stereos stereos = new Stereos("Living Room stereo");
            StereoOnWithCDCommand stereoOnWithCD =new StereoOnWithCDCommand(stereos);
            StereoOffCommand stereoOff = new StereoOffCommand(stereos);


            remoteControl.setCommand(0,lightOn,lightOff);
            remoteControl.setCommand(1,kitChenlightOn,kitChenlightOff);
            remoteControl.setCommand(2,ceilingFanOn,ceilingFanOff);
            remoteControl.setCommand(3,stereoOnWithCD,stereoOff);

            Console.WriteLine(remoteControl.ToString());

            remoteControl.onButtonWasPressed(0);
            remoteControl.offButtonWasPressed(0);
            remoteControl.undoButtonWasPressed();

            remoteControl.onButtonWasPressed(1);
            remoteControl.offButtonWasPressed(1);
            remoteControl.undoButtonWasPressed();

            remoteControl.onButtonWasPressed(2);
            remoteControl.offButtonWasPressed(2);
            remoteControl.undoButtonWasPressed();

            remoteControl.onButtonWasPressed(3);
            remoteControl.offButtonWasPressed(3);
            remoteControl.undoButtonWasPressed();
            //remoteControl.onButtonWasPressed(4);
            //remoteControl.offButtonWasPressed(4);
            Console.ReadLine();

        }

    }
}