using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;

            number1 = number2;
            number2 = 100;
            Console.WriteLine("Number1 : "+number1);
        }
    }
}
