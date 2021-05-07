using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsModifier
{
    public class Calculator
    {
        public static int CalculateSum(params int[] numbers) // With Params We can pass array
        {
            var sum = numbers.Sum();
            return sum;
        }
    }
}
