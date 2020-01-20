using System;

namespace SimpleClassExample
{
    class Car
    {

        public string petName;
        public int currSpeed;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        public Car(string pn)
        {
            petName = pn;
        }

        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public void PrintState ()
        => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        public void Speedup(int delta)
        => currSpeed += delta;
    }
}
