using System;
using System.Collections.Generic;
using System.Text;

namespace MaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 4, 19, 44, 95, 74, 28, 84, 79 };
            // Используем цикл for
            int max = array[0];
            int min = array[0];
           
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }

            Console.WriteLine("Максимальное значение " + max);
            Console.WriteLine("Минимальное значение " + min);

            // Используем цикл foreach
            max = array[0];
            min = array[0];

            foreach (int value in array)
            {
                if (value < min)
                    min = value;
                if (value > max)
                    max = value;
            }

            Console.WriteLine("Максимальное значение " + max);
            Console.WriteLine("Минимальное значение " + min);

            Console.ReadLine();
        }
    }
}
