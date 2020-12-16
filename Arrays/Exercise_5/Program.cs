using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 30;
            int[] intArray = new int[size];
            int min, indx = 0;


            Random rn = new Random();

            min = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rn.Next(15);

                if (intArray[i] < min)
                {
                    min = intArray[i];         
                }
            }

            Console.Write("\nMinimum is {0}", min);


          /*  foreach (int item in intArray)
            {
                Console.Write("|{0}| ", item);
            }


            Console.Write("\nMinimum is ");

            min = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                    Console.Write(" " + min + "\n");
                    Console.Write("index(es): {0} ", i);
        
                }
                else if(intArray[i] == min)
                {
                    Console.Write("{0} ", i);
                }
                
            }
          */
          




        }
    }
}
