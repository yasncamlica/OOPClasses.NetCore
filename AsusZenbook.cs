using System;
using System.Threading;

namespace OOPExample
{
    public class AsusZenbook : Laptop
    {
        int milliseconds = 2000;

        public override void TurnOn()
        {
            base.PowerOnSelfTest();
            Thread.Sleep(milliseconds);
            this.BIOSROM();
            Thread.Sleep(milliseconds);
            this.BootLoader();
            Thread.Sleep(milliseconds);
            this.OsConfig();
            Thread.Sleep(milliseconds);
            this.Security();
            Thread.Sleep(milliseconds);
            Console.WriteLine("Turning on AsusZenbook");
        }

        private void BIOSROM()
        {
            Console.WriteLine("BIOS ROM process...");
        }

        private void BootLoader()
        {
            Console.WriteLine("BootLoader phase is happening...");
        }

        private void OsConfig()
        {
            Console.WriteLine("OS configuration phase is happening...");
        }

        private void Security()
        {
            Console.WriteLine("Security logon phase is happening...");
        }

    }
}
