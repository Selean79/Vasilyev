using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace DPhotoWorkshop.Engine.Borders
{
    public class FrameColorScheme
    {
        public FrameColorScheme(string name)
        {
            Name = name;
            FillColor = Colors.White;
            StrokeColor = Colors.Black;
        }

        public FrameColorScheme(string name, Color fillColor, Color strokeColor)
        {
            Name = name;
            FillColor = fillColor;
            StrokeColor = strokeColor;
        }

        public string Name { get; set; }
        public Color FillColor { get; set; }
        public Color StrokeColor { get; set; }
    }
}
