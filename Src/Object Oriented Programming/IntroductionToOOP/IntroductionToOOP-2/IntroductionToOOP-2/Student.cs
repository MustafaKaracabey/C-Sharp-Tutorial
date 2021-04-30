using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToOOP_2
{
   public class Student
    {
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Double MidtermNote { get; set; }
        public Double FinalNote { get; set; }
        public Double Average { get; set; }

        public void CalculateAverage()
        {       
            this.Average = FinalNote * 0.6 + MidtermNote * 0.4 ;
        }
            


    }

}
