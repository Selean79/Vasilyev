using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeSpanProject
{
    public partial class Form1 : Form
    {
        DateTime dt;
        public Form1()
        {
            InitializeComponent();

            dt = DateTime.Now;
            dateTimeLabel.Text = dt.ToString();
        }

        private void addSomeMinutesButton_Click(object sender, EventArgs e)
        {
            dt = dt.Add(new TimeSpan(0, 15, 0));
            dateTimeLabel.Text = dt.ToString();
        }

        private void getOneHourButton_Click(object sender, EventArgs e)
        {
            dt = dt.Add(new TimeSpan(-1, 0, 0));
            dateTimeLabel.Text = dt.ToString();
        }
    }
}
