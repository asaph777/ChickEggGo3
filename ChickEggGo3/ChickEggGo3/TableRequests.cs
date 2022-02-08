using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickEggGo3
{
    class TableRequests
    {
        private IMenuItem[][] itm = new IMenuItem[8][];
        public void Add(int customer, IMenuItem item)
        {
            int n = 0;
            if (itm[customer] != null)
            {
                n = itm[customer].Length;
            }
            Array.Resize(ref itm[customer], n+1);
           itm[customer][n] = item;
        }
        public IMenuItem[] this[IMenuItem item]
        {
          
            get {
                IMenuItem[] zakazs = new IMenuItem[0];
                int n = 0;
                for (int i = 0; i < itm.Length; i++)
                {
                    if (itm[i] != null)
                    {
                        for (int j = 0; j < itm[i].Length; j++)
                        {
                            if (itm[i][j].GetType() == item.GetType())
                            {
                               Array.Resize(ref zakazs, zakazs.Length + 1);
                               zakazs[n] = itm[i][j];
                               n++;
                            }
                        }
                    }
                    
                }
                return zakazs;
            }
        }
        public IMenuItem[] this[int customer]
        {
            get {
                IMenuItem[] zakazs = new IMenuItem[1];
                zakazs = itm[customer];
                return zakazs;
            }
        }
    }
}
