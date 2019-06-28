using System;
namespace OOPExample
{
    public class AsusZenbook : Laptop
    {

        public override void TurnOn()
        {
            Console.WriteLine("Turning on AsusZenbook");
        }

        public override void TurnOn(bool accessBIOS)
        {
            if (accessBIOS)
            {
                Console.WriteLine("Accessing BIOS on AsusZenbook");
            }
            else
            {
                Console.WriteLine("Not accessing BIOS on AsusZenbook");
            }
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turning off AsusZenbook");
        }



        public override bool TouchScreen => true;

    }
}
