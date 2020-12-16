using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.Write("Enter size of Array: ");

            try
            {
                 size = Int32.Parse(Console.ReadLine());
                 
                int[] arr = new int[size];
                int x = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                     

                    if (i % 5 == 2)
                    {
                        arr[i] = i;
                    }

                    if (x == 5)
                    {
                        Console.WriteLine();
                        x = 0;
                    }

                    x++;
                }

                foreach (int item in arr)
                {
                    Console.Write("{0, 4}",item);
                }
            }
            catch
            {
                Console.WriteLine("Nessasary entering integer value!");
            }

            

        }
    }
}
