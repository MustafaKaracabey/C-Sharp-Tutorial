using System;

namespace Inheritance_2
{
    public class Car : Vehicle
    {
        public Car(string carName)
            : base(carName)
        {
            Console.WriteLine("Constructor from Car");
        }
    }
}