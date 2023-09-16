using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCMS
{
    class StopState:State
    {

        public int Ostate = 3;
        public void doAction()
        {
            Ostate = 0;
        }

        public int getState()
        {
            return Ostate;
        }
    }
}
