using System;

public class Macbook : Laptop
{

    public override void TurnOn()
    {
        Console.WriteLine("Turning on MacbookAir");
    }

    public override void TurnOn(bool accessBIOS)
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

    public override void TurnOff()
    {
        Console.WriteLine("Turning off MacbookAir");
    }




    public override bool TouchScreen => false;

    
}