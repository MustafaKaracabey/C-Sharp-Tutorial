using System;
using IntoductionToOOP_6.Entities;
using IntoductionToOOP_6.Screens;

namespace IntoductionToOOP_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var mustafaBank = new Bank("MUSTAFABANK", 10000000);
            var kadirBank = new Bank("KADIRBANK", totalMoney: 2000000);

            User user = new User("floytAX","123456");
            user.Money = 100;
            user.Accounts.Add(new Account("FloytaxAccount-1", user.Money, "TR 12365478966547896541236547" ,user.UserName,user.Password));
         
            mustafaBank.Accounts.Add(user.Accounts[0]);

            while (true)
            {
                var flag = 0;
                var login = mustafaBank.Login(user);
                if ( login )
                {
                    while (true)
                    {
                        var operation = LoginScreen.BankOperations();

                        if (operation == 1)
                        {
                            mustafaBank.AddMoney(user);
                            var value = LoginScreen.LastOtherQuestion();
                            if (value == 2)
                            {
                                flag = 1;
                                break;
                            }
 
                        }
                        else if (operation == 2)
                        {
                        
                        }
                        else if (operation == 3)
                        {
                        
                        }
                    }
                   
                   
                }

                if (flag == 1)
                    break;
                
                

            }

            Console.WriteLine("Thanx to use OUR BANKK !!");


        }
    }
}