using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Xml;

namespace DPhotoWorkshop.Engine.Borders
{
    public class PalaroidPhotoFrame : BasePhotoFrame
    {
        double frameWidthInPercent = 0.03;
        public Double FrameWidthInPercent
        {
            get { return frameWidthInPercent * 100; }
            set { frameWidthInPercent = value / 100; }
        }

        double bottomFramePercent = 0.10;
        public double BottomFramePercent
        {
            get { return bottomFramePercent * 100; }
            set { bottomFramePercent = value / 100; }
        }

        protected override void FillPath(Path path, Panel parent)
        {
            GeometryGroup group = new GeometryGroup();
            group.FillRule = FillRule.EvenOdd;

            RectangleGeometry rectangle1 = new RectangleGeometry();
            rectangle1.Rect = new Rect(0, 0, parent.Width, parent.Height);
            group.Children.Add(rectangle1);

            RectangleGeometry rectangle2 = new RectangleGeometry();
            rectangle2.Rect = new Rect(parent.Width * frameWidthInPercent, parent.Height * frameWidthInPercent,
                parent.Width * (1 - frameWidthInPercent * 2), parent.Height * (1 - bottomFramePercent - frameWidthInPercent));
            group.Children.Add(rectangle2);

            path.Data = group;
        }

        protected override void SaveAdditionalData(XmlTextWriter xmlOut)
        {
            xmlOut.WriteAttributeString("FrameWidthInPercent", frameWidthInPercent.ToString());
            xmlOut.WriteAttributeString("BottomFramePercent", bottomFramePercent.ToString());
        }

        protected override void LoadAdditionalData(XmlTextReader xmlIn)
        {
            FrameWidthInPercent = Convert.ToInt32(xmlIn.GetAttribute("FrameWidthInPercent"));
            BottomFramePercent = Convert.ToInt32(xmlIn.GetAttribute("BottomFramePercent"));
        }

        protected override int FrameKind()
        {
            return BASE_FRAME_PALAROID;
        }

        protected override string FrameKindName()
        {
            return "Palaroid frame";
        }
    }
}
