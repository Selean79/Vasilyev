using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Клик");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Опа");
        }
    }
}
