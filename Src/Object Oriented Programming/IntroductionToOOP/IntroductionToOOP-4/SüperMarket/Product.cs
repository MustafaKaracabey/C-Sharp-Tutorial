using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SüperMarket
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockCount { get; set; }
        public int Price { get; set; }

        #region Constructor

        public Product(int id)
        {
            Id = id;
        }

        public Product(int id, string name, int stockCount, int price)
            :this(id)
        {
            Name = name;
            StockCount = stockCount;
            Price = price;

        }


        #endregion



    }
}
