using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Excersise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 123456789123456789;
            Console.WriteLine();

            Console.WriteLine(x);

            /* Вариант программы с диалоговым окном

               string sname, name;

               name = Interaction.InputBox("Введите ваше имя", "Имя");
               sname = Interaction.InputBox("Ведите вашу фамилию", "Фамилия");

               MessageBox.Show(sname + " " + name);
            */

            // Вариант программы с консольным выыодом
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string sname, name;
            

            Console.Write("Введите ваше имя: ");
          
            name = Console.ReadLine();

          
            Console.Write("Введите вашу фамилию: ");
          
            sname = Console.ReadLine();

            Console.WriteLine();
            
            Console.Write("Вы ->> ");
            
            Console.WriteLine(sname + name);



        }
    }
}
