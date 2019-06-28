using System;
using System.Collections.Generic;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop asusZenbook = new AsusZenbook();
            Laptop macbookAir = new Macbook();

            asusZenbook.TurnOn();
            macbookAir.TurnOn();
        }
    }

    
}
