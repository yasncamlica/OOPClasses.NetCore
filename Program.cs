using System;
using System.Collections.Generic;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<Laptop> laptops = new List<Laptop>() { new Macbook(), new AsusZenbook() };

            foreach(var laptop in laptops)
            {
                laptop.TurnOn();
                laptop.TurnOn(true);
            }

        }
    }

    
}
