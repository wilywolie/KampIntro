using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(){KursAdı = "C#", egitmen = "Ahmet Akdemir", izlenmeOranı = 68};
            Kurs kurs2 = new Kurs() { KursAdı = "JS", egitmen = "unknown", izlenmeOranı = 55 };
            Kurs kurs3 = new Kurs() { KursAdı = "Python", egitmen = "unknown", izlenmeOranı = 95 };

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı +" "+ kurs.egitmen+" "+ kurs.izlenmeOranı);
            }


        }

       

    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOranı { get; set; }

    }
}
