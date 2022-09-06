using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyMouse.@class
{
    internal class Jiggler
    {
        public Jiggler()
        {
            
        }

        public void Toggle(int frequencyInterval)
        {
            this.jigglerThread = new Thread(this.JigglerHandler_Thread)
        }

        private void JigglerHandler_Thread()
        {
            
        }

        private Thread jigglerThread;
    }
}
