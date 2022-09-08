using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace CrazyMouse.@class
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int GetPointValue()
        {
            return X+Y;
        }
    }

    internal class Jiggler
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out POINT point);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetCursorPos(int x, int y);

        public Jiggler()
        {
            
        }

        public void Toggle(int frequencyInterval)
        {
            this.state = !this.state;
            if (this.state == true)
            {
                this.jigglerThread = new Thread(() => this.JigglerHandler_Thread(frequencyInterval*1000));
                this.jigglerThread.Start();
            }
        }

        private void JigglerHandler_Thread(int delay)
        {
            GetCursorPos(out this.mousePosition);

            while (this.state){
                Thread.Sleep(delay);
                GetCursorPos(out POINT currentCursorPosition);
                if (this.mousePosition.GetPointValue() == currentCursorPosition.GetPointValue())
                {
                    this.SetRandomCursorPosition();
                }
                GetCursorPos(out this.mousePosition);
            }

        }

        public void SetRandomCursorPosition()
        {
            Random randomize = new Random();
            int x = randomize.Next(0, 1920);
            int y = randomize.Next(0, 1080);
            while(x + y == mousePosition.GetPointValue())
            {
                x = randomize.Next(0, 1920);
                y = randomize.Next(0, 1080);
            }
            SetCursorPos(x, y);
        }

        private Thread jigglerThread;
        private POINT mousePosition;
        private bool state = false;
    }
}
