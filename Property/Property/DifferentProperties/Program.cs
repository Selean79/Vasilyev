using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentProperties
{
    class MyClass
    {
        private int[] nums;

        public string Content
        {
            get
            {
                if (nums == null)
                {
                    return "{ }";
                }

                string txt = "{" + nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    txt += "," + nums[i];
                }
                txt += "}";

                return txt;
            }
        }

        public int Element
        {
            set
            {
                if (nums == null)
                {
                    nums = new int[1];
                    nums[0] = value;
                }
                else
                {
                    int[] n = new int[nums.Length + 1];
                    for (int i = 0; i < nums.Length; i++)
                    {
                        n[i] = nums[i];
                    }
                    n[nums.Length] = value;
                    nums = n;
                }
            }
        }

        public int[] Data
        {
            get
            {
                int[] res = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    res[i] = nums[i];
                }
                return res;
            }

            set
            {
                nums = new int[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    nums[i] = value[i];     
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            ob.Element = 10;
           
            Console.WriteLine(ob.Content);

            ob.Element = 30;
            ob.Element = 60;

            Console.WriteLine(ob.Content);

            int[] A = ob.Data;
            ob.Element = 12;

            foreach (int l in A)
            {
                Console.Write(l + " ");
            }

            Console.WriteLine('\n' + ob.Content);

            int[] B = { 11, 3, 6 };
            ob.Data = B;

            B[0] = 0;

            foreach (int r in B)
            {
                Console.Write(r + " ");
            }

            Console.WriteLine('\n' + ob.Content);
        }
    }
}
