using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_1
{
    public static class Helper
    {
        public static void ShowCustomerOrderList(Customer customer)
        {

            customer.Orders.ForEach(x => Console.WriteLine(x.OrderName));

        }
    }
}
