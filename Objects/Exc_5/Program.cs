using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_5
{
    class MyClass
    {
        private int x;

       public MyClass()
        {
            this.x = 0;
            Show();
        }

        public MyClass(int x)
        {
            if (x > 100)
            {
                this.x = 100;
                Show();
            }
            else
            {
                this.x = x;
                Show();
            }
        }

        public void MyMethod()
        {
            this.x = 0;
            Show();
        }

        public void MyMethod(int x)
        {
            if (x > 100)
            {
                this.x = 100;
            }
            else
            {
                this.x = x;
            }
            Show();
        }

        public void Show()
        {
            Console.WriteLine("x = {0}", x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            ob.Show();
        }
    }
}
