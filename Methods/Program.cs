using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] meyveler = new string[] { };

            Product urun1 = new Product() { Adı = "elma", price = 15, Aciklama = "Amasya Elması" };
            Product urun2 = new Product() { Adı = "karpuz", price = 50, Aciklama = "Diyarbakır Karpuzu" };
            Product[] urunler = new Product[] { urun1, urun2 };
            foreach (Product urun in urunler)
            {   
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.price);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------------------------");


            }
            Console.WriteLine("---------Methods------------");

            //instance 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
           
        }
    }
}
