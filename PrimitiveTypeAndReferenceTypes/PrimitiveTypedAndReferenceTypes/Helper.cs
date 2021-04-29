using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypedAndReferenceTypes
{
    public class Helper
    {

        public static void Inrecement(int number3)
        {
            number3 += 10;
            Console.WriteLine($"Your Number is {number3} ");
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
