using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace FormVB
{
    class InputDialogForm
    {
        static void Main(string[] args)
        {
            string res;
            string txt;

            int year = 2019;
            int age, born;

            res = Interaction.InputBox("В каком году Вы родились?", "Год рождения");
            born = Int32.Parse(res);
            age = year - born;

            txt = "Тогда Вам " + age + " лет";

            MessageBox.Show(txt, "Возраст");
        }
    }
}
