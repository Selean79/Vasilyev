using System;

namespace exc_2
{
    class MyClass
    {
        private int[] myArray;

        public MyClass(int n)
        {
            myArray = new int[n];
        }

        public static string operator ~(MyClass ob)
        {
            string s = null;
            foreach (int k in ob.myArray)
            {
                s += (string)(k + " ");
            }

            return s;
        }

        public static MyClass operator ++(MyClass ob)
        {
            MyClass ob2 = new MyClass(ob.myArray.Length + 1);
            // ob = ob2;
            return ob2;
        }

        public static MyClass operator --(MyClass ob)
        {
            MyClass ob2 = new MyClass(ob.myArray.Length - 1);
            //  ob = ob2;
            return ob2;
        }

        public static MyClass operator +(MyClass ob, MyClass ob1)
        {
            MyClass ob2 = new MyClass(ob.myArray.Length + ob1.myArray.Length);
            //ob = ob2;
            return ob2;
        }

         public static MyClass operator +(MyClass ob, int n)
        {
            MyClass ob1 = new MyClass(ob.myArray.Length + n);
            ob1.myArray[ob1.myArray.Length - 1] = n;
            return ob1;
        }

        public static MyClass operator +(int n, MyClass ob)
        {
            MyClass ob1 = new MyClass(ob.myArray.Length + n);
            ob1.myArray[0] = n;
            return ob1;
        }


        public override string ToString()
        {
            string s = null;
            foreach (int i in myArray)
            {
                s += i + " ";
            }
            return s;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass(2);
            MyClass ob1 = new MyClass(5);
            Console.WriteLine(ob);
            Console.WriteLine(~ob);
            Console.WriteLine(++ob);
            Console.WriteLine(++ob);
            Console.WriteLine(--ob);
            Console.WriteLine(new String('-', 10));
            Console.WriteLine(ob + ob1); 
            MyClass ob3 = new MyClass(2);
            MyClass ob4 = new MyClass(2);
            Console.WriteLine(5 + ob3);
            Console.WriteLine(ob4 + 10);

        }
    }
}
