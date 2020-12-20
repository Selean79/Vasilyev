using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows;
using System.Xml;

namespace DPhotoWorkshop.Engine.Borders
{
    public class CircleFrame : BasePhotoFrame
    {
        protected override void FillPath(Path path, Panel parent)
        {
            GeometryGroup group = new GeometryGroup();
            group.FillRule = FillRule.EvenOdd;

            RectangleGeometry rectangle = new RectangleGeometry();
            rectangle.Rect = new Rect(0, 0, parent.Width, parent.Height);
            group.Children.Add(rectangle);

            EllipseGeometry circle = new EllipseGeometry();
            circle.Center = new Point(parent.Width / 2, parent.Height / 2);
            circle.RadiusX = parent.Width / 2 - 4;
            circle.RadiusY = parent.Height / 2 - 4;
            group.Children.Add(circle);

            path.Data = group;
        }

        protected override void SaveAdditionalData(XmlTextWriter xmlOut)
        {
        }

        protected override void LoadAdditionalData(XmlTextReader xmlIn)
        {
        }

        protected override int FrameKind()
        {
            return BASE_FRAME_CIRCLE;
        }

        protected override string FrameKindName()
        {
            return "Circle frame";
        }
    }
}
