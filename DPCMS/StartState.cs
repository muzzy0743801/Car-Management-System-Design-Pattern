using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCMS
{
    class StartState:State
    {
        //stte
        public int Ostate =3;
        public void doAction()
        {
            Ostate = 1;
        }

        public int getState()
        {
            return Ostate;
        }
    }
}
