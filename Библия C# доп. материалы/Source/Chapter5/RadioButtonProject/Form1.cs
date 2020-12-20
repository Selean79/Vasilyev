using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonProject
{
    public partial class Form1 : Form
    {
        bool CanChange = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (CanChange)
                radioButton3.Checked = !radioButton3.Checked;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("radioButton1");
            if (radioButton2.Checked)
                MessageBox.Show("radioButton2");
            if (radioButton3.Checked)
                MessageBox.Show("radioButton3");
        }
    }
}
