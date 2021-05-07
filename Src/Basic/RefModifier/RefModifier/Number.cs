using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefModifier
{
    public static class Number
    {
        public static void ChangeByRefIncrement(ref int num)
        {
            num += 1;
        }
    }
}
