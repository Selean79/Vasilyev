using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SympleStMeth
{
    class MyClass
    {
        static public void Test1()
        {
            Console.WriteLine("Static method 2");
        }
    }
    
    class Program
    {
        static public void Test(string str)
        {
            Console.WriteLine(str);
            return;
        }

        static public void Test3(string str)
        {
            Console.WriteLine("Static method 3");
            Test(str);
            return;
        }

        static void Main(string[] args)
        {
            Test3("Hi Everyone!");   
        }
    }
}
