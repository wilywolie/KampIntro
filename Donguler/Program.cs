using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <= kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            foreach (var kurs in kurslar)   
            {
               Console.WriteLine(kurs);
            }
        }

        static string[] kurslar = new string[] {"asd","asdas","wqeqw","AS:DAS" };


    }
}
