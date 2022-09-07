using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer() { CustomerNo="12345",Name="Ahmet",Surname="Akdemir",TcNo="1234",CustomerId=1};
            TuzelCustomer customer2 = new TuzelCustomer() {CustomerId=2,CampanyName="akdemirltd.",CustomerNo="123",TaxNo="434" };

            Customer customer3 = new RealCustomer();
            Customer customer4 = new TuzelCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer4);
            customerManager.Add(customer1);


        }
    }
}
