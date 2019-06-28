using System;
using System.Collections.Generic;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            //Laptop macbookAir = new Macbook();
            //Laptop asusZenbook = new AsusZenbook();

            //macbookAir.TurnOn();
            //macbookAir.TurnOn(true);

            //asusZenbook.TurnOn();
            //asusZenbook.TurnOn(false);






            //2
            List<Laptop> laptops = new List<Laptop>() { new Macbook(), new AsusZenbook() };

            foreach(var laptop in laptops)
            {
                laptop.TurnOn();
                laptop.TurnOn(true);
            }

        }
    }

    
}
