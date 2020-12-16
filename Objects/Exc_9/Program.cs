using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_9
{
    class MyClass
    {
                
        public static void MyMethod(params int[] k)
        {

            int min = k[0];
            int max = k[1];

            if(min > max)
            {
                max = k[0];
                min = k[0];
            }



            for (int i = 2; i < k.Length; i++)
            {
                   
                if (k[i] > max)
                {
                    max = k[i];
                }
                else if(k[i] < min)
                {
                    min = k[i];
                }
            }

            Console.WriteLine("min = {0} / max = {1}", min, max);
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 2, 3, 40, 5, 6, 0, 125, -25};
            MyClass.MyMethod(array);
        }
    }
}
