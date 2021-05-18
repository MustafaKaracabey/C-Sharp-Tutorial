using System;
using IntoductionToOOP_5.Enums;

namespace IntoductionToOOP_5.Controllers
{
    public static class MoneyMeasure
    {
        
        public static int Measure(string type,int numberCounter)
        {
            
            switch (type)
            {
                
                case nameof(TicketType.Big):
                    var unitBigMoney = 1000000 / 8;
                    return unitBigMoney * numberCounter;
                    
                
                case nameof(TicketType.Medium):
                    var unitMedMoney = 25000 / 8 ;
                    return unitMedMoney * numberCounter;
                
                case nameof(TicketType.Small):
                    var unitSmallMoney = 5000 / 8;
                    return unitSmallMoney * numberCounter;
                
                default:
                    Console.WriteLine("Something Wrong !!!");
                    return 1;
            }
        }
    }
}