using System;

namespace Exc_6
{
    class MyClass
    {
        public int num;

        public MyClass(int n)
        {
            num = n;
        }

        public static bool operator true(MyClass ob)
        {
            switch (ob.num)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    return true;
                default:
                    return false;
            }
        }

        public static bool operator false(MyClass ob)
        {
            if (ob.num < 1 || ob.num > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static MyClass operator &(MyClass ob1, MyClass ob2)
        {
            if (ob1)
            {
                return ob2;
            }
            else
            {
                return ob1;
            }
        }

        public static MyClass operator |(MyClass ob1, MyClass ob2)
        {
            if (ob1)
            {
                return ob1;
            }
            else
            {
                return ob2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass(7);
            MyClass ob3 = (ob1 || ob2);
            Console.WriteLine(ob3.num);

        }
    }
}
