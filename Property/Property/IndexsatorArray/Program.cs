using System;

namespace IndexsatorArray
{
    class MyClass
    {
        private int code;

        public MyClass(char s)
        {
            code = s;
        }

        public char this[int k]
        {
            get
            {
                return (char)(code + k);
            }
            set
            {
                code = value - k;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass('A');

            for (int i = 0; i < 10; i++)
            {
                Console.Write(ob[i] + " ");
            }
        }
    }
}
