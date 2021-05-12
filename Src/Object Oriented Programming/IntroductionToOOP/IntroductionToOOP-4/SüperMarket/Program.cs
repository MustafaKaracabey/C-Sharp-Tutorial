using System;
using System.Collections.Generic;

namespace SüperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Bim bim = new Bim();
            bim.Id = 1;
            bim.Location = "a";

            
            

            A101 a101 = new A101();
            a101.Id = 2;
            a101.Location = "b";

            a101.Products = new List<Product>() ;

            Product tea1 = new Product(1, "Tea", 4, 20);
            Product tea2 = new Product(2, "Tea", 2, 30);

            Product water = new Product(3, "Water", 3, 5);
            

            Product potato1 = new Product(4, "Potato", 2, 8);
            Product potato2 = new Product(5, "Potato", 6, 4);

            Product sugar1 = new Product(6, "Sugar", 1, 12);
            Product sugar2 = new Product(7, "Sugar", 1, 16);

            Product bear = new Product(8, "Bear", 2, 3);
            Product tiger = new Product(9, "Tiger", 4, 5);


            List<Product> bimProducts = new List<Product>() { tea1, water, potato1, sugar1, bear };
            List<Product> a101Products = new List<Product>() { tea2, water, potato2, sugar2, tiger };

            bim.Products = bimProducts;
            a101.Products = a101Products;


            Person a = new Person(1,"a",1000);
            Person b = new Person(1, "b", 1000);


            Dictionary<string, int> myNeeds = new Dictionary<string, int>();

            myNeeds.Add("Tea", 2);
            myNeeds.Add("Sugar", 2);
            myNeeds.Add("Water", 2);
            myNeeds.Add("Potato", 4);
            myNeeds.Add("Tiger", 1);

            Dictionary<string, int> mySecondNeeds = new Dictionary<string, int>();

            mySecondNeeds.Add("Tea", 3);
            mySecondNeeds.Add("Water", 3);
            mySecondNeeds.Add("Potato", 2);
            mySecondNeeds.Add("Sugar", 2);
            mySecondNeeds.Add("Bear", 1);

            a.GetShopping(bim, myNeeds);
            a.ShowMyProducts(a);

            b.GetShopping(a101, mySecondNeeds);
            b.ShowMyProducts(b);


        }
    }
}
