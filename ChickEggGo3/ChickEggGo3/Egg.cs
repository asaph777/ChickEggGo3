using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickEggGo3
{
   sealed class Egg: CoockedFood, IDisposable
    {
        public Egg(int Quantity) : base(Quantity){}
        public void GetQuality()
        {
        }
        public void Crack()
        {

        }
        public void Discard()
        {

        }
        public override void Prepare()
        {
            for (int i = 0; i < Quantity; i++)
            {
                Crack();
                Discard();
            }
            Cook();
        }

        public void Dispose()
        {
            
        }
    }
}
