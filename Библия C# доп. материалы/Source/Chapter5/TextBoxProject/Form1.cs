using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextBoxProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = lastnameTextBox.Text;
            MessageBox.Show(str);
        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            label3.Text = lastnameTextBox.Text;
        }

        private void lastnameTextBox_ModifiedChanged(object sender, EventArgs e)
        {
            if (lastnameTextBox.Modified)
                label2.Text = "Изменен";
            else
                label2.Text = "Сохранен";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastnameTextBox.Modified = false;
        }
    }
}
