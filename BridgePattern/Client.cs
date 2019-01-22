using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Client
    {
        public void Run()
        {
            var combo = new CokeAndChips();
            var comboTwo = new MilkAndCookies();

            List<Burgers> burgers = new List<Burgers>();
            burgers.Add(new ChickenBurger(combo));
            burgers.Add(new ChickenBurger(comboTwo));

            foreach (var burger in burgers)
            {
                Console.WriteLine(burger.ToString());
            }
        }
        

    }
}
