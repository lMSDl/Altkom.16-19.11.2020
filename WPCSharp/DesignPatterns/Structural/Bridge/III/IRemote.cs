using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Bridge.III
{
    public interface IRemote
    {
        void ChannelDown();

        void ChannelUp();

        void TogglePower();

        void VolumeDown();

        void VolumeUp();
    }
}
