using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickEggGo3
{
    
    class Server
    {
        private TableRequests tt = new TableRequests();
        public static int counReqs = 0;
        private Cook cook = new Cook();
        public void Recieve(int countChick, int countEgg, string drink)
        {
            for (int i = 0; i < countChick; i++)
            {
                tt.Add(counReqs, new Chicken(1));
            }
            for (int i = 0; i < countEgg; i++)
            {
                tt.Add(counReqs, new Egg(1));
            }
            switch (drink)
            {
                case "Tea":
                    tt.Add(counReqs, new Tea());
                    break;
                case "Coca-Cola":
                    tt.Add(counReqs, new CocaCola());
                    break;
                case "Pepsi":
                    tt.Add(counReqs, new Pepsi());
                    break;
                default:
                    tt.Add(counReqs, new NoDrink());
                    break;
            }
           counReqs++;
        }
        public void Send()
        {
            cook.Process(tt);
        }
        public string[] Serve()
        {
            string[] results = new string[0];
            for (int i = 0; i < counReqs; i++)
            {
                int countChicken = 0;
                int countEgg = 0;
                string choiseDrink = "";
                string resultItem = "";
                foreach (var item in tt[i])
                {
                    item.Obtain();
                    if (item is Chicken)
                    {
                        countChicken++;
                    }
                    else if (item is Egg)
                    {
                        countEgg++;
                    }
                    else
                    {
                        if (item is Tea)
                        {
                            choiseDrink = " Tea";
                        }
                        else if (item is CocaCola)
                        {
                            choiseDrink = " Coca - Cola";
                        }
                        else if (item is Pepsi)
                        {
                            choiseDrink = " Pepsi";
                        }
                        else
                        {
                            choiseDrink = " No Drink";
                        }
                        
                    }
                    item.Serve();
                    resultItem = $"Customer {i} is served {countChicken} chickens, {countEgg} eggs, {choiseDrink}"; 
                }
                Array.Resize(ref results, results.Length + 1);
                results[results.Length - 1] = resultItem;
            }
            Array.Resize(ref results, results.Length + 1);
            results[results.Length - 1] = "Please enjoy your food!";
            return results;
        }
    }
}
