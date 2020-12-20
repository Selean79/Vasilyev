using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DateTimePickerProject
{
    public partial class DateTimeForm : Form
    {
        public DateTimeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker2.Value;
            MessageBox.Show(dt.ToString());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker2.Value.ToString());
        }
    }
}
