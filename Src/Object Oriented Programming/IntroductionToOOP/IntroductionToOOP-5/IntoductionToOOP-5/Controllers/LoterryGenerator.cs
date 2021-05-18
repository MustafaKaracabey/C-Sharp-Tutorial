using System.Collections.Generic;
using IntoductionToOOP_5.Entities;
using IntoductionToOOP_5.Helper;

namespace IntoductionToOOP_5.Controllers
{
    public static class LoterryGenerator
    {
        public static List<int> Numbers { get; set; }

         static LoterryGenerator()
        {
            Numbers = new List<int>();
        }
        public static List<int> GetLotteryNumbers()
        {
            var numberGenerator = new NumberGenerator();
            for (int i = 0; i <8 ; i++)
                Numbers.Add(numberGenerator.CreateNumber());

            return Numbers;
        }
    }
}