using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_7
{
    class MyClass
    {
        /*private*/ public string txt;

        public MyClass(string st)
        {
            txt = st;
        }

        public static explicit operator int(MyClass ob)
        {
            return ob.txt.Length;
        }

        public static explicit operator char(MyClass ob)
        {
            return ob.txt[0];
        }

        public static implicit operator MyClass(int x)
        {
            string str = null;

            for (int i = 0; i <= x; i++)
            {
                str += "A";
            }

            ;
            return new MyClass(str);
        }

        public override string ToString()
        {
            return this.txt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass("Andrew");

            int n = (int)ob;
            char ch = (char)ob;
            MyClass ob1 = (MyClass)15;
            
            Console.WriteLine(n);
            Console.WriteLine(ch);


            Console.WriteLine(ob1);


        }
    }
}
