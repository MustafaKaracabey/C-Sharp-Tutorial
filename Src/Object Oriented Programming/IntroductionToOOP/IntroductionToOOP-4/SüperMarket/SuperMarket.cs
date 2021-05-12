using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SüperMarket
{
   public class SuperMarket
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public string Location { get; set; }
    }
}
