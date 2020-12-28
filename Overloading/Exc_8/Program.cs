using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_8
{
    class MyClass
    {
        private int[] arrayNum;

        public MyClass(int[] arr)
        {
            arrayNum = arr;
        }

        public static explicit operator string(MyClass ob)
        {
            string txt = null;
            for (int i = 0; i < ob.arrayNum.Length; i++)
            {
                txt += ob.arrayNum[i];
            }
            return txt;
        }

        public static explicit operator int(MyClass ob)
        {
            int sum = 0;
            for (int i = 0; i < ob.arrayNum.Length; i++)
            {
                sum += ob.arrayNum[i];
            }

            return sum;
        }

        public static explicit operator MyClass(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            
            return new MyClass(arr);
        }

        public override string ToString()
        {
            string txt = "";
            for (int i = 0; i < arrayNum.Length; i++)
            {
                txt += arrayNum[i] + " ";
            }
            return txt; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] tr = { 1, 2, 3, 6, 15};
            MyClass ob = new MyClass(tr);

            string txt = (string)ob;
            Console.WriteLine(txt);

            int s = (int)ob;
            Console.WriteLine(s);

            MyClass ob1 = (MyClass)15;
            Console.WriteLine(ob1);
        }
    }
}
