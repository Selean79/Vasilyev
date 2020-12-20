using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            String str = "Hello world";
            resultTextBox.Text += "Начальное значение: " + str + "\r\n";
            resultTextBox.Text += "Длина: " + str.Length + "\r\n";
            resultTextBox.Text += "Содержит слово 'world': " + str.Contains("world") + "\r\n";
            resultTextBox.Text += "Содержит слово 'мир': " + str.Contains("мир") + "\r\n";
            resultTextBox.Text += "Пример форматирования: " + String.Format("Сейчас будет приветствие миру '{0}'", str) + "\r\n";
            resultTextBox.Text += "Содержит слово 'мир': " + str.Contains("мир") + "\r\n";
            resultTextBox.Text += "Позиция слова 'world': " + str.IndexOf("world") + "\r\n";
            resultTextBox.Text += "Вставка слова': " + str.Insert(5, " мир") + "\r\n";
            resultTextBox.Text += "Выравнивание вправо: " + str.PadLeft(20) + "\r\n";
            resultTextBox.Text += "Удаление 3 символов начиная с 2: " + str.Remove(2, 3) + "\r\n";
            resultTextBox.Text += "Подмена строки: " + str.Replace("world", "мир") + "\r\n";
            resultTextBox.Text += "Подстрока с 0 по 5 символ: " + str.Substring(0, 5) + "\r\n";
            resultTextBox.Text += "Подстрока с 0 по 5 символ: ";
            char[] chars = str.ToCharArray();
            foreach (char ch in chars)
                Console.WriteLine(ch);
            resultTextBox.Text += "\r\n";
            resultTextBox.Text += "Конечное значение: " + str + "\r\n";
        }
    }
}
