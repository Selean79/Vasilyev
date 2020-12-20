using System;

namespace Exc_1
{
    class MyClass
    {
        char ch;

        public MyClass(char c)
        {
            ch = c;
        }

        public static MyClass operator ++(MyClass ob)
        {
            ob.ch = (char)(ob.ch + 1);
            return ob;
        }

        public static MyClass operator --(MyClass ob)
        {
            ob.ch = (char)(ob.ch - 1);
            return ob;
        }

        public static MyClass operator +(MyClass ob, int n)
        {
            ob.ch = (char)(ob.ch + n);
            return ob;
        }

        public static MyClass operator +(int n, MyClass ob)
        {
            return ob + n;
        }

        public static int operator -(MyClass ob1, MyClass ob2)
        {
            return (int)(ob1.ch) - (int)(ob2.ch);
        }


        public override string ToString()
        {
            string txt = "char: " + ch;
            return txt;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass('a');
            MyClass ob2 = new MyClass('s');
            ob1++;
            Console.WriteLine(ob1);
            ob1--;
            Console.WriteLine(ob1);
            Console.WriteLine(ob1 + 3);
            Console.WriteLine(5 + ob1);

            Console.WriteLine(new String('-', 10));
            Console.WriteLine(ob2);
          
            Console.WriteLine(ob1);
            Console.WriteLine(ob2 - ob1);
            Console.WriteLine(ob1 - ob2);
        }
    }
}
