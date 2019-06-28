using System;

    public abstract class Laptop
    {

        public abstract void TurnOn();

        public abstract void TurnOn(bool accessBIOS);

        public abstract void TurnOff();

        public abstract bool TouchScreen {get;}
    }