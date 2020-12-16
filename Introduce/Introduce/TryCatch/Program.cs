using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TryCatch
{
    class TryCatchDemo
    {
        static void Main(string[] args)
        {

            MessageBox.Show("Выполняется программа", "Начало");
            try
            {
                Double.Parse(Interaction.InputBox("Введите действительное число:", "Число"));
                MessageBox.Show("Да, это было число!", "Число");
            }
            catch
            {

                MessageBox.Show("Надо было ввести число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Программа завершена!", "Завершение");
        }
    }
}
