using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Modifier
{
    public static class Number
    {

        //Out Keyword can update multiple parameter otherwise,ref keyword Can not
        // No need to initialize variable if out keyword is used.otherwise,ref you have to Initialize   
        public static void ChangeNumberByOut(out int number, out int number2)
        {
            number = 1;
            number2 = 1;
        }
    }
}
