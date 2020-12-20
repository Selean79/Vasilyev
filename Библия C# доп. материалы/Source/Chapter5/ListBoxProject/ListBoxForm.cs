using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxProject
{
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string str in listBox1.SelectedItems)
                MessageBox.Show(str);
        }
    }
}
