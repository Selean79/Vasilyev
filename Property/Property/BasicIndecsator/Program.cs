using System;

namespace BasicIndecsator
{
    class MyClass
    {
        private int[] nums;

        public MyClass(int n)
        {
            nums = new int[n];
            for (int k = 0; k < nums.Length; k++)
            {
                nums[k] = 0;
            }
        }

        public override string ToString()
        {
            string txt = "{" + nums[0];
            for (int k = 0; k < nums.Length; k++)
            {
                txt += "," + nums[k];
            }
            txt += "}";

            return txt;
        }

        public int Length
        {
            get
            {
               return nums.Length;
            }
        }

        public int this[int k]
        {
            get
            {
                return nums[k];
            }
            set
            {
                nums[k] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass(5);

            Console.WriteLine(ob);

            for (int i = 0; i < ob.Length; i++)
            {
                ob[i] = 2 * i + 1;
            }

            Console.WriteLine(ob);

            for (int i = 0; i < ob.Length; i++)
            {
                Console.WriteLine(" " + ob[i]);
            }
        }
    }
}
