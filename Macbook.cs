using System;
using System.Threading;

public class Macbook : Laptop
{

    int milliseconds = 2000;

    public override void TurnOn()
    {
        this.BootROMLoaded();
        Thread.Sleep(milliseconds);
        this.BootROMRunning();
        Thread.Sleep(milliseconds);
        this.PowerOnSelfTest();
        Thread.Sleep(milliseconds);
        this.FindBoosterFile();
        Thread.Sleep(milliseconds);
        this.LoadKernel();
        Thread.Sleep(milliseconds);
        Console.WriteLine("Turning on MacbookAir");
    }

    private void BootROMLoaded()
    {
        Console.WriteLine("BootROM loaded...");
    }

    private void BootROMRunning()
    {
        Console.WriteLine("BootROM running...");
    }

    private void FindBoosterFile()
    {
        Console.WriteLine("Finding booter file...");
    }

    private void LoadKernel()
    {
        Console.WriteLine("Booter loads the Kernel...");
    }


}