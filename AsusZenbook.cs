using System;
namespace OOPExample
{
    public class AsusZenbook : Laptop
    {
        public bool TouchScreen => true;

        public void TurnOff()
        {
            Console.WriteLine("Turning off AsusZenbook");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on AsusZenbook");
        }

        public void TurnOn(bool accessBIOS)
        {

            if(accessBIOS)
            {
                Console.WriteLine("Accessing BIOS on AsusZenbook");
            }
            else
            {
                Console.WriteLine("Not accessing BIOS on AsusZenbook");
            }
        }
    }
}
