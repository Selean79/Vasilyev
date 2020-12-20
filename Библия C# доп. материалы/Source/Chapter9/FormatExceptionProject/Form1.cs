using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormatExceptionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(inputNumberTextBox.Text);
            MessageBox.Show("Вы ввели: " + index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(inputNumberTextBox.Text);

                if (index > 10)
                    throw new Exception("Вы ввели слишком большое значение");

                MessageBox.Show("Вы ввели: " + index);
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели некорректное число");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message);
            }
            finally
            {
            }
        }
    }
}
