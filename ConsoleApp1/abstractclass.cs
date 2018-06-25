using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
    //abstract class cannot be sealed and sealed cannot be abstract 
    public abstract class Customer: ICustomer
    {
        //abstract class can have fields
        public int ID;

        public abstract void EnrollCustomer();

        //abstract class can have non abstract members which would have implementation on the abstratc class
        public void GenerateBill()
        { }

        public void NonAccessControl()
        { }


    }
    //interface can inherit from interface and not abstract class
    interface ICustomer
    {
        //derived class must have this implementation and would not have access modifier
        void NonAccessControl();

        //interfaces cannot have fields
    }

    //class can inherit from multiple interface but not from multiple abstract class
    public class Supermarket: Customer
    {
        public static void Main()
        {
            //abstract class cannot be instanciated but referenced
            Customer C1 = new Supermarket();
            C1.EnrollCustomer();
            Console.ReadKey();
        }

        //use override keyword to override the abstract defination
        public override void EnrollCustomer()
        {
            Console.WriteLine("abstract overridden method");
        }
    }

}
