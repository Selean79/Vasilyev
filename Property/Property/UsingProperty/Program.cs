using System;

namespace UsingProperty
{
    class Program
    {
        class MyClass
        {
            private int first;
            private int last;
            private int test;

            public MyClass(int a, int b)
            {
                first = a;
                last = b;
            }

            public override string ToString()
            {
                string txt = "object's fields: ";
                txt += first + " and " + last;
                return txt;
            }

            public int Number
            {
                get
                {
                    int t = last;
                    last = first;
                    first = t;
                    return t;
                }

                set
                {
                    last = first;
                    first = value;
                }
            }
        }
        static void Main(string[] args)
        {
            MyClass ob = new MyClass(1, 9);
            Console.WriteLine(ob);
            Console.WriteLine("Property Number: " + ob.Number);
            Console.WriteLine(ob);
            ob.Number = 5;
            Console.WriteLine(ob);
            Console.WriteLine("Property Number: " + ob.Number);
            Console.WriteLine(ob);
        }
    }
}
