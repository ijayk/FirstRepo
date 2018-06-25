using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This namespace would oultline the concept of polymorphism

namespace Part23
{
    public class Employee
    {
        public string FN = "Jayanta";
        public string LN = "Chakravorty";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FN + " " + LN);
            Console.WriteLine("This is the parent call method");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FN + " " + LN  + "-PartTimeEmployee");
            Console.WriteLine("This is the child call method");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FN + " " + LN + "-FullTimeEmployee");
            Console.WriteLine("This is the child call method");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FN + " " + LN + "-TemporaryEmployee");
            Console.WriteLine("This is the child call method");
        }
    }

    public class Program
    {
        public static void Main()
        {
            
            Employee E = new Employee();
            E.PrintFullName();
            Console.WriteLine("Calling the base class constructor\n");

            Employee[] Earray = new Employee[4];
            Earray[0] = new PartTimeEmployee();
            Console.WriteLine("Calling the derived class constructor from base instance with new\n");
            Earray[1] = new TemporaryEmployee();
            Earray[2] = new FullTimeEmployee();
            Earray[3] = new Employee();

            foreach (Employee e in Earray)
            {
                e.PrintFullName();
            }

            //new keyword merely hides the parent method when calling from derived class
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.PrintFullName();
            Console.WriteLine("Calling the derived class method from child instance with new\n");

            //this should call the parent method
            Employee PTEE = new PartTimeEmployee();
            PTEE.PrintFullName();
            Console.WriteLine("Calling the derived class method from parent instance with new\n");

            //override keyword overrides the method from both the class
            TemporaryEmployee TE = new TemporaryEmployee();
            TE.PrintFullName();
            Console.WriteLine("Calling the derived class method from child instance with override\n");
            Employee TEE = new TemporaryEmployee();
            TEE.PrintFullName();
            Console.WriteLine("Calling the derived class method from parent instance with override\n");


            Console.ReadKey();
        }
        
    }
}
