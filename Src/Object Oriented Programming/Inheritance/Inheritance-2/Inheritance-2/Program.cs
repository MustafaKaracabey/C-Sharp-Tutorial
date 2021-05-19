using System;

namespace Inheritance_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("BMW");
        }
    }
}

/*
 * Protected : Accessible only from class and derived class
 * Internal : Accessible only from same assembly (internal is a modifier that we often use with classes not their members)
 * Protected internal Accessible only from same assembly or any derived classes (mix protected internal :))
 */
 
 /*
  *Base Class Constructor always executes first
  * Base Class Constructor are not inherited
  *
  * 
  */