using System;

    public abstract class Laptop
    {

        public abstract void TurnOn();

        protected void PowerOnSelfTest()
        {
            Console.WriteLine("Checking processors...");
            Console.WriteLine("Checking system memory...");
            Console.WriteLine("Checking network...");
            Console.WriteLine("Checking USB...");
            Console.WriteLine("Checking Bluetooth...");
        }
    }