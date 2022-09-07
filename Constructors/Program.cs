using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer{ID = 1,FirstName = "ahmet"};
            Customer customer1 = new Customer(2, "ahmet");

            Console.WriteLine(customer1.FirstName);
        }

        static void Method(int id, string firstName)
        {

        }
    }


    class Customer
    {
        //default constructor parametre yoksa
        public Customer()
        {
            
        }
        // another constructor for using with parameters

        public Customer(int id, string firstName)
        {
            ID = id;
            FirstName = firstName;

        }
        public int ID { get; set; }
        public string FirstName { get; set; }
    }
}
