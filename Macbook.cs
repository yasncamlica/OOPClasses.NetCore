using System;

public class Macbook : Laptop
{
    public bool TouchScreen => false;

    public void TurnOff()
    {
        Console.WriteLine("Turning off MacbookAir");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on MacbookAir");
    }

    public void TurnOn(bool accessBIOS)
    {
        if (accessBIOS)
        {
            Console.WriteLine("Accessing BIOS on Macbook");
        }
        else
        {
            Console.WriteLine("Not accessing BIOS on Macbook");
        }
    }
}