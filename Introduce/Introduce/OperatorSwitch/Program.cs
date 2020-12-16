using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OperatorSwitch
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            int number;
            string name;

            number = Int32.Parse(Interaction.InputBox("Введите число:", "Ввод целого числа"));

            switch (number)
            {
                case 1:
                    name = "Единица";
                    break;

                case 2:
                    name = "Двойка";
                    break;

                case 3:
                    name = "Тройка";
                    break;

                case 4:
                    name = "Четверка";
                    break;

                default:
                    name = "Вы ввели другое число...";
                    break;
            }

            MessageBox.Show(name);

        }
    }
}
