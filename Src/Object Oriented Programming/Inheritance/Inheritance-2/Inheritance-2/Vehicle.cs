using System;

namespace Inheritance_2
{
    public class Vehicle
    {
        private readonly string _carName; 
        public Vehicle(string carName)
        {
            _carName = carName;
            Console.WriteLine("Constructor from Vehicle");
        }
        
    }
}