using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = (int)yearNumericUpDown.Value;
            int month = (int)monthNumericUpDown.Value;
            int day = (int)dayNumericUpDown.Value;
            int hour = (int)hourNumericUpDown.Value;
            int minute = (int)minutesNumericUpDown.Value;

            DateTime dt = new DateTime(year, month, day, hour, minute, 0);
            dayOfWeekLabel.Text = dt.DayOfWeek.ToString();
            dayOfWeekNumberLabel.Text = ((int)dt.DayOfWeek).ToString();
            timeOfDayLabel.Text = dt.TimeOfDay.ToString();
            dayOfYearLabel.Text = dt.DayOfYear.ToString();
        }
    }
}
