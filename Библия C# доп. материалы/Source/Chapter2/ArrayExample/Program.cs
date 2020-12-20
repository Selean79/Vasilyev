using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив чисел
            int[] intArray = new int[3];

            intArray[0] = 0;
            intArray[1] = 1;
            intArray[2] = 2;

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);

            Console.ReadLine();

            // дни недели
            string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            Console.WriteLine(weekDays[2]);

            Console.ReadLine();
        }
    }
}
