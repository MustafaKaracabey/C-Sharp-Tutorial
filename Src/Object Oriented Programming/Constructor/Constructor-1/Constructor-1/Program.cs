using System;

namespace Constructor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Mustafa", 1);

            var pizza = new Order("Pizza");
            var hamburger = new Order("Hamburger");

            customer.Orders.Add(pizza);
            customer.Orders.Add(hamburger);

            Helper.ShowCustomerOrderList(customer);
        }
    }
}
