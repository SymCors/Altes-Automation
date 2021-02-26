﻿using System;

namespace Automation
{
    class Device9EventArgs : EventArgs
    {
        public string speed, length;
        public bool running;
        public static event EventHandler<Device9EventArgs> event1;

        public Device9EventArgs() { }
        public Device9EventArgs(bool runningInfo, string speedInfo, string lengthInfo)
        {
            speed = speedInfo;
            length = lengthInfo;
            running = runningInfo;
        }

        protected virtual void onDataReceived(Device9EventArgs e)
        {
            event1?.Invoke(this, e);
        }

        public void sendEventInfo(bool runningInfo, string speedInfo, string lengthInfo)
        {
            onDataReceived(new Device9EventArgs(runningInfo, speedInfo, lengthInfo));
        }
    }
}
