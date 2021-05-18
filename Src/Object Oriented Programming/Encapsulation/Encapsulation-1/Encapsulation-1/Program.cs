using System;

namespace Encapsulation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            
            person.SetBirthDate(DateTime.Now);

            Console.WriteLine("My BirthDATE İS : " + person.GetBirthday());
        }
    }
}