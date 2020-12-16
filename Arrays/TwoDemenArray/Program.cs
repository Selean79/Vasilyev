using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDemenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3, cols = 5;

            int[,] nums = new int[rows, cols];

            int value = 1;

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int k = 0; k < nums.GetLength(1); k++)
                {
                    nums[i, k] = value;
                    value++;

                    Console.Write(nums[i, k] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
