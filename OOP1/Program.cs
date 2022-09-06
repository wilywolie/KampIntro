using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(){Id = 1, ProductName = "Masa",CategoryId = 2,UnitPrice = 500,UnitsInStock = 3};
            Product product2 = new Product()
                { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            

        }
    }
}
