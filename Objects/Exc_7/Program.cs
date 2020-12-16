using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_7
{
    class ClassString
    {
        private string txt;
        private char ch;

        public void MethodText(char ch)
        {
            this.ch = ch;
            Console.WriteLine("ch = {0}", ch);
        }

        public void MethodText(string txt)
        {
            this.txt = txt;
            Console.WriteLine("txt = {0}", txt);
        }

        public void MethodText(char[] chArray)
        {
            if (chArray.Length == 1)
            {
                this.ch = chArray[0];
                Console.WriteLine("ch = {0}", ch);
            }
            else
            {
                foreach (char k in chArray)
                {
                    txt += k;
                }
                Console.WriteLine("txt = {0}", txt);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char[] k = { 'l', 'o', 'v', 'e' };
            ClassString ob = new ClassString();
            ob.MethodText("laksjajd;");
        }
    }
}
