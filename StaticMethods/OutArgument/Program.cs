using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutArgument
{
    class UsingOutDemo
    {
        static int Getint(int[] nums, out int index)
        {
            index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[index])
                {
                    index = i;
                }
            }

            return nums[index];
        }
        static void Main(string[] args)
        {
            int[] A = { 12, 7, 8, 3, 8, 49, 4, 1, 3, 4, 1, 7, 15 };

            foreach (int k in A)
            {
                Console.Write("| {0} ", k);
            }
            Console.WriteLine('|');

            int val, j;

            val = Getint(A, out j);

            Console.WriteLine("Min value: " + val);
            Console.WriteLine("Element's index: " + j);
            Console.WriteLine("Check: A{0} = {1}", j, A[j]);

        }
    }
}
