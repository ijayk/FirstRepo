using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICustomer
    {
        void Print();
    }

    interface ICustomer2
    {
        void Print();
    }

    //multiple interface inheritance is allowed
    public class Customer : ICustomer , ICustomer2
    {
        //common implementation
        public void Print()
        {
            Console.WriteLine("HI");
        }

        //explicit interface implememntation no access modifiers alowed
        void ICustomer.Print()
        {
            Console.WriteLine("I1");
        }

        void ICustomer2.Print()
        {
            Console.WriteLine("I2");
        }
    }
    
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.Print();

            //interface calling
            ICustomer C2 = new Customer();
            C2.Print();

            //type cast calling
            ((ICustomer2)C2).Print();

            Console.ReadKey();
        }
       
    }

}
