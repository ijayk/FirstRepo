using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This gives the demo for encapsulation
namespace Properties
{
    public class Student
    {
        public int Id;
        private int Age;


        //procedural language used getter and setter methods
        public void SetAge(int SetAge)
        {
            if (SetAge <= 3)
            {
                throw new Exception("Child too small");
            }
            Age = SetAge;
        }
        public int GetAge()
        {
            return Age;
        }

        //can use properties like this now and can be accessed like natural variable
        private string _name;

        //use of value is mandatory else the value is not set for these properties
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name Cannot be null");
                }
                this._name = value;
            }
            get
            {
                //using ternary operator
                return string.IsNullOrEmpty(this._name) ? "John Doe" : this._name;
            }
        }


        //auto setter and accessor with no business rule by c# 3.0
        public string City
        {
            get;
            set;
        }

        private string _School;

        //read only properties would only have getter
        public string School 
        {
        get
            {
                return "Mount Carmel School";
            }
        }
    }
    public class School
    {
        public static void Main()
        {
            Student NewStudent = new Student();

            //procedural language had getter setter method
            NewStudent.SetAge(15);
            Console.WriteLine("Age of the new student is {0}", NewStudent.GetAge());
            Console.WriteLine("The Name has Not Been Set and Value is {0}", NewStudent.Name);
            //Now there are properties that set and get 
            NewStudent.Name = "Jay";
            Console.WriteLine("The Name has Now Been Set and Value is {0}", NewStudent.Name);
            NewStudent.City = " ";
            Console.WriteLine("The city has auto getter setter and value is {0}", NewStudent.City);
            //Not allowed as this is readonly
            //NewStudent.School ="Some School"
            Console.WriteLine("The school has readonly value is {0}", NewStudent.School);
            //same goes for write only properties
            Console.ReadKey();

        }
        
    }
}
