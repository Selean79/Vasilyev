using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace Designer
{
    class Rose
    {
        const int DEFAULT_WIDTH = 50;
        const int DEFAULT_HEIGHT = 46;
        Image roseImage = Designer.Properties.Resources.Roze;

        public Rose(string name, int x, int y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Width = DEFAULT_WIDTH;
            this.Height = DEFAULT_HEIGHT;
        }

        #region Свойства

        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Size Size 
        {
            get { return new Size(Width, Height); }
        }

        public Point Location
        {
            get { return new Point(X, Y); }
        }            

        #endregion

        #region Открытые Методы

        public void Draw(Graphics g)
        {
            g.DrawImage(roseImage, X, Y, Width, Height);
            g.DrawString(Name, SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X, Y + Height));
        }

        #endregion
    }
}
