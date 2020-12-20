using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class Program
    {
        static int[] array = { 10, 98, 78, 4, 54, 25, 84, 41, 30, 87, 60, 84, 6, 12 };

        static void Main(string[] args)
        {
            sort(0, array.Length-1);
            foreach (int i in array)
                Console.WriteLine(i);
            Console.ReadLine();
        }

        static void sort(int l, int r)
        {
            int i = l;
            int j = r;
            int x = array[(l + r) / 2];
            
            do
            {
                while (array[i] < x) i++;
                while (array[j] > x) j--;
                if (i <= j)
                {
                    int y = array[i];
                    array[i] = array[j];
                    array[j] = y;
                    i++;
                    j--;
                }
            } while (i < j);
            
            if (l < j)
                sort(l, j);
            if (l < r)
                sort(i, r);
        }
    }
}
