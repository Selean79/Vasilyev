using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateProject
{
    class Program
    {
        public delegate int Factorial(int number);

        static void Main(string[] args)
        {
            Factorial fact_delegate = new Factorial(FactorialFunc);
            IAsyncResult result = fact_delegate.BeginInvoke(10, new AsyncCallback(CallBack), "Это параметр");
            
            Console.WriteLine("Можете что-то ввести:");
            Console.ReadLine();

            int fact = fact_delegate.EndInvoke(result);
            
            Console.WriteLine("Результат: {0}", fact);
        }
    
        public static int FactorialFunc(int number)
        {
            int fact = 1;
            for (int i = 2; i < number; i++)
            {
                fact *= i;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Результат из потока: {0}", fact);
            return fact;
        }

        static void CallBack(IAsyncResult asyncResult)
        {
            string s = (string)asyncResult.AsyncState;
            Console.WriteLine("Асинхронный метод завершился");
            Console.WriteLine("Получено значение: " + s);
        }
    }
}
