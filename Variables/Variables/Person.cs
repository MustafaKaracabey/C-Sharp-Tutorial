using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void IntroducePerson ()
        {
            Console.WriteLine($"My name is: {this.Name} and My Surname is: {this.Surname}");
        }
    }
}
