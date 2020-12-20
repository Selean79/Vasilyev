using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ListboxDrawingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (String str in Enum.GetNames(typeof(DashStyle)))
            {
                if (str != "Custom")
                    listBox1.Items.Add(str);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // прорисовка фона
            e.DrawBackground();

            // определяю имя текущего элемента
            string currName = listBox1.Items[e.Index].ToString();

            // определяю стиль
            DashStyle dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), currName);

            // создаю перо
            Pen p = new Pen(Color.Red, 2);
            p.DashStyle = dashStyle;

            // рисую прямоугольник
            e.Graphics.DrawRectangle(p, e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 4, e.Bounds.Height - 4);
            e.Graphics.DrawString(currName, e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + 2, e.Bounds.Y);

            // рисую рамку выделения
            e.DrawFocusRectangle();
        }
    }
}
