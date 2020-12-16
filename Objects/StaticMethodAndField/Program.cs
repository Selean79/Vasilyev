using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodAndField
{
    class MyClass
    {
        public static int code = 100;
        public int x = 52;

        public static void show()
        {
            Console.WriteLine("Static Field: " + code);
        }
    }
    class StaticDemo
    {
        static void Main(string[] args)
        {
            MyClass.show();
            MyClass.code = 555;
            MyClass.show();
        }
    }
}
