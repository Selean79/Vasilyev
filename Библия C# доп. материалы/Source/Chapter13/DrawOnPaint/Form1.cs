using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphIntroProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            const string HELLO_WORLD = "Hello World!!!";

            SizeF messageSize = e.Graphics.MeasureString(HELLO_WORLD, Font);
            PointF p = new PointF((ClientSize.Width - messageSize.Width) / 2,
                (ClientSize.Height - messageSize.Height) / 2);
            
            e.Graphics.DrawString(HELLO_WORLD, Font, SystemBrushes.WindowText, p);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
