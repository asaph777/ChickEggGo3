using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickEggGo3
{
    abstract class CoockedFood : IMenuItem
    {
        private int quantity;
        protected CoockedFood(int quantityFood)
        {
            quantity = quantityFood;
        }
        public int Quantity
        {
            get { return quantity; }
        }
        public void Cook() { }
        public void Obtain(){}
        public virtual void Prepare() { }
        public void Serve(){}
    }
}
