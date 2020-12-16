using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OperatoIf
{
    class UsingIdDemo
    {
        static void Main(string[] args)
        {
            MessageBoxIcon icon;
            string msg, title, name;

            name = Interaction.InputBox("Как вас зовут?", "Знакомство");

            if (name == "")
            {
                icon = MessageBoxIcon.Error;
                msg = "Очень жаль, что мы не познакомились...";
                title = "Знакомство не состоялось";
            }
            else
            {
                icon = MessageBoxIcon.Information;
                msg = "Мне очень приятно, " + name + "!";
                title = "Знакомство состоялось";
            }

            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);

           
        }
    }
}
