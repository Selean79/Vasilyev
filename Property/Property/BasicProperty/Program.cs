using System;

namespace BasicProperty
{
    class MyClass
    {
        private int num;
        private int min;
        private int max;

        public MyClass(int a, int b)
        {
            if (a > b)
            {
                min = a;
                max = b;
            }
            else
            {
                min = b;
                max = a;
            }
            
            num = (max + min) / 2;
        }

        public int Code
        {
            get
            {
                return num;
            }
            set
            {
                if (value < min)
                {
                    num = min;
                }
                else if(value > num)
                {
                    num = max;
                }
                else
                {
                    num = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass(10, 9);
            Console.WriteLine($"Property Code: {ob.Code}");
            ob.Code = 7;
            Console.WriteLine($"Property Code: {ob.Code}");
            ob.Code = 20;
            Console.WriteLine($"Property Code: {ob.Code}");
            ob.Code = -10;
            Console.WriteLine($"Property Code: {ob.Code}");
        }
    }
}
