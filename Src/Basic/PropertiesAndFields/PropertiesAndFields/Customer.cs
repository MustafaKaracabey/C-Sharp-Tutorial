using System.Collections.Generic;

namespace PropertiesAndFields
{
    public class Customer
    {
        public readonly int Id; //Field (Readonly means You can not initialize this field)
        public string Name; //Field
        public List<Order> Orders = new List<Order>(); //Field
        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id,string name)
        :this(id)
        {
            Name = name;
        }
    }
}