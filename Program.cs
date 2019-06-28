using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop macbookAir = new Macbook();
            Laptop asusZenbook = new AsusZenbook();

            macbookAir.TurnOn();
            macbookAir.TurnOn(true);

            asusZenbook.TurnOn();
            asusZenbook.TurnOn(false);

           
        }
    }

    
}
