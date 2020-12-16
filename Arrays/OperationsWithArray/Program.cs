using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithArray
{
    class CopyArrayDemo
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 3, 5, 7, 9 };
            int[] B, C;

            B = A;

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("| " + B[i] + " ");
            }
            Console.WriteLine("|");

            C = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }

            A[0] = 0;
            B[B.Length - 1] = 55;

            Console.WriteLine();
            for (int k = 0; k < A.Length; k++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", A[k], B[k], C[k]);
            }

            Console.ReadLine();
        }
    }
}
