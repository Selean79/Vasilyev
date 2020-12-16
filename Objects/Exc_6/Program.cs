using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_6
{
    class MaxMin
    {
        private int min = 0, max;

        public void CompareMinMax()
        {
            max = min = 0;
        }

        public void CompareMinMax(int x)
        {
            if (x > min)
            {
                max = x;
            }
            else
            {
                min = x;
            }
        }

        public void CompareMinMax(int x, int k)
        {
            if (x > k)
            {
                max = x;
                min = k;
            }
            else
            {
                min = x;
                max = k;
            }
        }

        public void Show()
        {
            if (max == min)
            {
                Console.WriteLine("min = max = {0}", min);
            }
            else
            {
                Console.WriteLine("min = {0}, max = {1}", min, max);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MaxMin ob = new MaxMin();
            ob.CompareMinMax();
            ob.Show();
        }
    }
}
