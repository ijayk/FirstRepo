using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Customer
    {
        private int _id;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
    }

    //object initialiser syntax introduced in C# 3
    
        //structs cannot be inheritedd from or inherit from class but inherit from interface as they are sealed
        //public class Method : Customer
    public class Method 
    {
        Customer C1 = new Customer
        {
            ID = 103
        };

        //structs cannot have parameter less constructor 
        //this is a destructor 
        ~Method()
        {

        }
    }

}
