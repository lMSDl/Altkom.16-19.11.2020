using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    public class Client
    {
        public static void Execute()
        {

            var remote = new Remote();
            var tv = new TvRemoteAdapter(new TvRemote());
            var hifi = new HiFiRemoteAdapter(new HiFiRemote());

            remote.DeviceAdapter = tv;
            remote.TogglePower();
            remote.ChannelDown();
            remote.VolumeUp();

            remote.DeviceAdapter = hifi;
            remote.TogglePower();
            remote.VolumeUp();

            remote.ChannelDown();

            remote.DeviceAdapter = tv;
            remote.TogglePower();
            remote.DeviceAdapter = hifi;
            remote.TogglePower();

        }
    }
}
