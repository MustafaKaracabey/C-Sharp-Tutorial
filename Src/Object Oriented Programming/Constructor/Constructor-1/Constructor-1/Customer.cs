using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_1
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set;}

        //Overloding : means having a method by the same name but different signatures
        public Customer() // Parameterless Constructor
        {
            this.Orders = new List<Order>();
        }
        public Customer(string name)
            : this() //Refers Parameterless Constructor 
        {
            
            this.Name = name;
        }
        public Customer(string name, int id)
            : this(name)
        {
            this.CustomerId = id;
        }
    }
}
