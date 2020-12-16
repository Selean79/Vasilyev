using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_4
{
    class CodTable
    {
        int x;
        char ch;

        public CodTable(int x, char ch)
        {
            this.x = x;
            this.ch = ch;
            Show();
        }

        public CodTable(double x)
        {
            x = (x - (int)x) * 100;
            this.x = (int)x;
            Show1();
        }

        public void Show()
        {
            Console.WriteLine("x = {0}\nch = {1}", x, ch);
        }

        public void Show1()
        {
            Console.WriteLine("x = {0}", x);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            CodTable ob = new CodTable(65, 'A');
            Console.WriteLine();
            CodTable ob1 = new CodTable(23.01);
            
        }
    }
}
