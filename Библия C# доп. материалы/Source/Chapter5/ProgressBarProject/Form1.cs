using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ProgressBarProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(100);
            }
        }
    }
}
