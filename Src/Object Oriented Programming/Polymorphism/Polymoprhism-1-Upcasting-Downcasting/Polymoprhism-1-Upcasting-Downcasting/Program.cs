using System;

namespace Polymoprhism_1_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case-1
            Employee employee = new Manager();
            Manager manager = (Manager) employee; //Downcasting (U have to Downcasting otherwise does not work )
            
            //case*2
            Manager manager1 = new Manager();
            Employee employee1 = manager1; //Upcasting with no explicit
            Employee employee2 = (Manager) manager1; //Upcasting with explicit

        }
    }
}

//Reference Work For Upcasitng https://www.c-sharpcorner.com/blogs/upcast-and-downcast-basics
