using System;

namespace Polymoprhism_1_Upcasting_Downcasting
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public void ShowName()
        {
            Console.WriteLine($"My name is { Name } and my Id is : { Id }");
        }
    }
}