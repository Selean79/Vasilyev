using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToMethod
{
    class ArrayToMethodDemo
    {
        static void FillRend(int[] nums)
        {
            Random rnd = new Random();
            for (int k = 0; k < nums.Length; k++)
            {
                nums[k] = rnd.Next(1, 101);
            }
        }

        static void ShowArray(int[] nums)
        {
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write("| {0}", nums[k]);
            }
            Console.WriteLine("|");
        }

        static void ShowArray(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int k = 0; k < nums.GetLength(1); k++)
                {
                    Console.Write("{0,3}", nums[i,k] );
                }
                Console.WriteLine();
            }
        }


        static int FindMin(int[] nums)
        {
            int s = nums[0];

            for (int k = 0; k < nums.Length; k++)
            {
                if (nums[k] < s)
                {
                    s = nums[k];
                }
            }

            return s;
        }


        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] B = new int[5];
            int[,] C = { {1, 2, 3, 4},{5,6,7,8},{9,10,11,12}};

            FillRend(B);

            Console.WriteLine("One-dimensional array A:");
            ShowArray(A);

            Console.WriteLine("One-dimensional array B:");
            ShowArray(B);

            int m = FindMin(B);
            Console.WriteLine("Min value is {0}", m);


            Console.WriteLine("Two-dimensional array C:");
            ShowArray(C);
        }
    }
}   
