using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product0 = new Product(){UrunAdı = "Iphone",UrunFiyat = 5500,UrunKategori = "Telefon"};
            Product product1 = new Product(){UrunKategori = "Laptop",UrunFiyat = 12000,UrunAdı = "Monster A5"};
            Product product2 = new Product(){UrunFiyat = 2500,UrunAdı = "AsusV24234",UrunKategori = "Monitör"};
            Product[] products = new[] {product0,product1, product2};
            foreach (var product in products)
            {
                Console.WriteLine(product.UrunAdı +" "+product.UrunKategori+" "+product.UrunFiyat);
            }


        }

        class Product
        {
            public string UrunAdı { get; set; }
            public string UrunKategori { get; set; }
            public int UrunFiyat { get; set; }

        }
    }
}
