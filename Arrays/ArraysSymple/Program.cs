using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSymple
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 6;
            nums[3] = 8;
            nums[4] = 111;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            

            int size = 10;
            char[] sym = new char[size];

            Console.WriteLine("\nArray: ");

            for (int i = 0; i < sym.Length; i++)
            {
                sym[i] = (char)('A' + rnd.Next(26));
                Console.Write("| " + sym[i] + " ");
            }

            Console.WriteLine("|");

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 };

            Console.ReadLine();
        }
    }
}
