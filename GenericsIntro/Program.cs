using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);
            isimler.Add("mehmet");
            Console.WriteLine(isimler.Length);
            isimler.Add("recep");
            Console.WriteLine(isimler.Length);

            foreach (var items in isimler.Items)
            {
                Console.WriteLine(items);
            }


        }
    }
}
