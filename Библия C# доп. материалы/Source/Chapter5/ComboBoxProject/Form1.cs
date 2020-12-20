using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new String[] { "Отлично",  "Хорошо"});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                String str = comboBox1.SelectedItem.ToString();
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("Ничего не выделено");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str = comboBox1.SelectedIndex.ToString();
            MessageBox.Show(str);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.flenov.info");
        }
    }
}
