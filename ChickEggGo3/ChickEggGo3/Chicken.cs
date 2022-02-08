using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickEggGo3
{
    class Chicken : CoockedFood
    {
        public Chicken(int quantityFood) : base(quantityFood){}
        public void CutUp()
        {

        }
        public override void Prepare()
        {
            for (int i = 0; i < Quantity; i++)
            {
                CutUp();
            }
            Cook();
        }
    }
}
