using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleinheritance
{
    class A: IA
    {
        public void printA()
        {
            Console.WriteLine("PrintA");
        }
    }

    interface IA
    {
        void printA();
    }
    class B
    {
        public void printB()
        {
            Console.WriteLine("PrintB");
        }
    }

    interface IB
    {
        void printB();
    }

    class C: IA,IB
    {
       
            A a = new A();
            B b = new B();

            public void printA()
            {
                a.printA();
            }

            public void printB()
            {
                b.printB();
            }
        
        


    }
}
