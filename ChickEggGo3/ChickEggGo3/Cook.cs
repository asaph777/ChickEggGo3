using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickEggGo3
{
    class Cook
    {
        public void Process(TableRequests tableRequests)
        {
            foreach (Chicken item in tableRequests[new Chicken(1)])
            {
                item.Obtain();
                item.CutUp();
                item.Cook();
            }
            foreach (Egg item in tableRequests[new Egg(1)])
            {
                item.Obtain();
                item.Crack();
                item.Cook();
                item.Dispose();
            }
        }
    }
}
