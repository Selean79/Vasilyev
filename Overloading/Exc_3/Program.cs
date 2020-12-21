using System;

namespace Exc_3
{
    class MyClass
    {
        int x, y;
        int sum;

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
            sum = (x * x) + (y * y);
        }

        public static bool operator <(MyClass ob1, MyClass ob2)
        {
            if (ob1.sum < ob2.sum)
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
            if (ob1.sum > ob2.sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(1, 1);
            MyClass ob2 = new MyClass(2, 2);

            if (ob1 > ob2)
            {
                Console.WriteLine("Object 1 < Object2");
            }
            else
            {
                Console.WriteLine("Object 1 > Object2");
            }
        }
    }
}
