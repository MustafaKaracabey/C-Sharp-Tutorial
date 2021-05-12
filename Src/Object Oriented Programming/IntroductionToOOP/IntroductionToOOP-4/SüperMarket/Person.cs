using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SüperMarket
{
   public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }

        public List<BoughtProduct> BoughtProducts { get; set; }


        #region Constructor
        public Person()
        {
            BoughtProducts = new List<BoughtProduct>();
        }

        public Person(int id, string name, int money)
            : this()
        {
            Id = id;
            Name = name;
            Money = money;
        }
        #endregion


        public void GetShopping(SuperMarket sm,Dictionary<string,int> myNeeds)
        {
  
            foreach (var product in sm.Products)
            {
                if (myNeeds.ContainsKey(product.Name))
                {
                    var item = myNeeds.Single(x => x.Key == product.Name);

                    if(product.StockCount >= item.Value)
                    {
                        BoughtProduct boughtProduct = new BoughtProduct()
                        {
                            Id = product.Id,
                            ProductName = product.Name,
                            Amount = item.Value
                        };
                        this.BoughtProducts.Add(boughtProduct);
                    }

                }


            }

        }

        public void ShowMyProducts(Person person)
        {
            Console.WriteLine("I am " + person.Name);
            foreach (var boughtProduct in BoughtProducts)
            {
                Console.WriteLine($"   {boughtProduct.ProductName} isimli üründen {boughtProduct.Amount} Tane aldım.");
            }

        }

    }
}
