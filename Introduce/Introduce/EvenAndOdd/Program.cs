using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace EvenAndOdd
{
    class OddEvenDemo
    {
        static void Main(string[] args)
        {
            int number, remindrer;

            number = Int32.Parse(Interaction.InputBox("Введите целое число: ", "Проверка"));

            remindrer = number % 2;

            string txt = "Вы ввели ";

            txt += (remindrer == 0 ? "четное" : "нечетное") + " число";

            MessageBox.Show(txt);
        }
    }
}
