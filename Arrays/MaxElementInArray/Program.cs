using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementInArray
{
    class MaxElementDemo
    {
        static void Main(string[] args)
        {
            int value, index, size = 15;

            Random rnd = new Random();

            int[] nums = new int[size];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 101);
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();

            index = 0;
            value = nums[index];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > value)
                {
                    value = nums[i];
                    index = i;
                }
            }

            Console.WriteLine("max element in array - {0}", value);
            Console.WriteLine("index of element - {0}",index);

            Console.Read();


        }
    }
}
