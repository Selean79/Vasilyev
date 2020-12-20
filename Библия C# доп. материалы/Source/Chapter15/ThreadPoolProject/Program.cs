using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadPoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(FactFunc);
            for (int i = 1; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(callback, i);                
            }
            Console.ReadLine();
        }

        static void FactFunc(Object state)
        {
            int num = (int)state;
            int result = 1;
            for (int i = 1; i <= num; i++)
                result *= i;
            Console.WriteLine(result);
        }
    }
}
