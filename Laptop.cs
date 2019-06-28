using System;

    public interface Laptop
    {

        void TurnOn();

        void TurnOn(bool accessBIOS);

        void TurnOff();

        bool TouchScreen {get;}
    }