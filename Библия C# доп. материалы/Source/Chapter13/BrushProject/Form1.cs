using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BrushProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point p1 = new Point(10, 10);
            Point p2 = new Point(10, ClientSize.Height - 10);

            Brush brush = new LinearGradientBrush(p1, p2, Color.Red, Color.Wheat);
            e.Graphics.FillRectangle(brush, 
                new Rectangle(10, 10, ClientSize.Width - 20, ClientSize.Height - 20));
        }
    }
}
