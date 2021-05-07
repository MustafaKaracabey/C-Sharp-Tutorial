using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_1
{
    public class Order
    {
        public string OrderName { get; set; }

        public Order(string orderName)
        {
            this.OrderName = orderName;
        }
    }
}
