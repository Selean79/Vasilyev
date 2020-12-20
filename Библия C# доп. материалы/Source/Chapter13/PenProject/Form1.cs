using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PenProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color c1 = Color.FromName("Green");

            Pen pen = new Pen(c1, 3);
                        
            int x = 10;
            // стили карандаша
            foreach (DashStyle dcp in Enum.GetValues(typeof(DashStyle)))
            {
                pen.DashStyle = dcp;
                e.Graphics.DrawLine(pen, new Point(x, 10), new Point(x, 100));
                x += 10;
            }

            x += 50;
            // ваш собственный рисунок
            pen.DashPattern = new float[] { 5.0F, 1.0F, 2.0F, 4.0F, 1.0F, 10.0F };
            e.Graphics.DrawLine(pen, new Point(x, 10), new Point(x, 100));

            x += 50;
            // смещение рисунка
            for (int i = 0; i < 5; i++)
            {
                pen.DashOffset = i;
                e.Graphics.DrawLine(pen, new Point(x, 10), new Point(x, 100));
                x += 10;
            }
        }
    }
}
