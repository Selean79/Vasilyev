using System;

namespace Exc_4
{
    class MyClass
    {
        private int num;
        private string str;

        public MyClass(int n, string st)
        {
            num = n;
            str = st;
        }

        public static bool operator <(MyClass ob1, MyClass ob2)
        {
            if (ob1.str.Length < ob2.str.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(MyClass ob1, MyClass ob2)
        {
            if (ob1.str.Length > ob2.str.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(MyClass ob1, MyClass ob2)
        {
            if (ob1.num <= ob2.num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(MyClass ob1, MyClass ob2)
        {
            if (ob1.num >= ob2.num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(MyClass ob1, MyClass ob2)
        {
            if (ob1.num == ob2.num && ob1.str == ob2.str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(MyClass ob1, MyClass ob2)
        {
            if (ob1.num == ob2.num && ob1.str == ob2.str)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override bool Equals(object obj)
        {
            MyClass t = (MyClass)obj;
            if (num == t.num && str == t.str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return 10 * num;
        }


    }

    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(3, "Andrew");
            MyClass ob2 = new MyClass(31, "Andrew");

            if (ob1 > ob2)
            {
                Console.WriteLine("String1 > String2");
            }
            else
            {
                Console.WriteLine("String1 < String2");
            }

            if(ob1 >= ob2)
            {
                Console.WriteLine("num1 >= num2");
            }
            else
            {
                Console.WriteLine("num1 <= num2");
            }

            if (ob1 == ob2)
            {
                Console.WriteLine("num1 == num2 && string1 == string2");
            }
            else
            {
                Console.WriteLine("num1 != num2 or string1 != string2");
            }

            Console.WriteLine(ob1.Equals(ob2));
            Console.WriteLine(ob1.GetHashCode());
            Console.WriteLine(ob2.GetHashCode());
        }
    }
}
