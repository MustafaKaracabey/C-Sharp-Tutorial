using System;
using IntoductionToOOP_6.Entities;

namespace IntoductionToOOP_6.Screens
{
    public static class LoginScreen
    {
        public static void WelcomeScreen(Bank bank, User user)
        {
            Console.WriteLine($"Welcome To  Mr { user.Name} { user.Surname} AMAZING { bank.Name }");
        }

        public static int BankOperations()
        {
            while (true)
            {
                
                Console.WriteLine("Please Enter Operation : ");
                Console.WriteLine($" 1- AddMoney \n 2- withDrawMoney \n 3-sendMoney"   );
                
                var value = Convert.ToInt32(Console.ReadLine());
                
                if (value == 1 || value == 2 || value == 3)
                    return value;
                
                Console.WriteLine("You can not Enter " + value);
            }
            

        }

        public static int LastOtherQuestion()
        {
            Console.WriteLine("Do you want to do Another Operation ?  Yes : 1, No : 2");

            var value = Convert.ToInt32(Console.ReadLine());

            return value;
        }
    }
}