using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WithoutPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            Graphics g = Graphics.FromHwnd(Handle);
            g.DrawRectangle(SystemPens.ActiveBorder,
                new Rectangle(10, 10, ClientSize.Width - 20, ClientSize.Height - 20));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
