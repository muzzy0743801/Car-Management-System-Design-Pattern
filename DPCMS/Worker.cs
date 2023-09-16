using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCMS
{
    public abstract class Worker
    {
        protected DecisionAPI designAPI;

        protected Worker(DecisionAPI designAPI)
        {
            this.designAPI = designAPI;
        }

        public abstract void open();
    }
}
