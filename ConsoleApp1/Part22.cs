using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This file introduces to the concept of abstraction
namespace Part22
{
    public class Parent
    {
        public String FirstName;

        //static keyword as the lastname would always be constant 
        //and this would always point to one class and not every instace of class
        public static String LastName;

        //static constructors are always called first and once
        static Parent()
        {
            LastName = "Chakravorty";
            Console.WriteLine("Static Constructor was Called");
        }

        //non static constructors are called then
        public Parent()
        {
            FirstName = "Prashanta & Reena";
            Console.WriteLine("Parent Constructor was Called");
        }

        public void PrintParentFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine("Parent has been called");
        }

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine("Parent has been called");
        }

    }


    public class Child : Parent
    {
        public string FirstName;
        
        //The warning is for parent method override, can be overridden by new keyword
       
        public void PrintFullName(String FirstName)
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine("Child has been called");
        }
    }

    public class Child2 : Parent
    {
        public string FirstName;
        public string LastName;
        //The warning is for parent method override, this can be removed by using keyword new 
        public void PrintFullName()
        {
            //can also call the parent method directly from here
            //base.PrintFullName()

            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine("Child has been called");
        }
    }

    public class Program
    {
        public static void Main()
        {
            

            Child Ananta = new Child();
            Ananta.FirstName = "Ananta";
            Ananta.PrintFullName(Ananta.FirstName);


            //another way of writing the same above code
            Child Jay = new Child
            {
                FirstName = "Jayanta"
            };
            Jay.PrintFullName(Jay.FirstName);

            //type cast child to parent to access parent overridden methods
            ((Parent)Jay).PrintFullName();

            Parent Jay1 = new Child
            {
                FirstName = "Jay Again"
            };
            //can access parent method directly
            Jay1.PrintFullName();

            //Cannot do this because you are declaring a child to be a new parent
            //Child1 Jay = new Parent();


            Console.ReadKey();
        }
         
        
    }
}
