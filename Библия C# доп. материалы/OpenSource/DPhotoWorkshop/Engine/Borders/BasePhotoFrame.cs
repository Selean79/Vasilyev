using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Xml;

namespace DPhotoWorkshop.Engine.Borders
{
    abstract public class BasePhotoFrame
    {
        public const int BASE_FRAME_CIRCLE = 1;
        public const int BASE_FRAME_PALAROID = 2;
        #region init

        Path framePath;

        public BasePhotoFrame()
        {
        }

        public BasePhotoFrame(Panel parent)
        {
            this.parent = parent;
        }

        #endregion

        #region properties

        StackPanel photoFramePanel;
        public StackPanel PhotoFramePanel
        {
            get { return photoFramePanel; }
        }

        Panel parent = null;
        public Panel Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        Color fillBrush = Colors.White;
        public Color FillColor
        {
            get { return fillBrush; }
            set 
            { 
                fillBrush = value;
                if (framePath != null)
                    framePath.Fill = new SolidColorBrush(FillColor);
            }
        }

        Color strokeBrush = Colors.Gray;
        public Color StrokeColor
        {
            get { return strokeBrush; }
            set 
            { 
                strokeBrush = value;
                if (framePath != null)
                    framePath.Stroke = new SolidColorBrush(StrokeColor);
            }
        }

        double strokeThickness = 1;
        public double StrokeThickness
        {
            get { return strokeThickness; }
            set 
            { 
                strokeThickness = value;
                if (framePath != null)
                    framePath.StrokeThickness = strokeThickness;
            }
        }

        int width = 200;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        int height = 150;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        #endregion

        #region public methods

        public void Visualize()
        {
            if (parent != null)
                Visualize(parent, Width, Height);
        }

        public virtual void Visualize(Panel parent, double width, double height)
        {
            photoFramePanel = new StackPanel();
            photoFramePanel.Name = "BorderFrame";
            photoFramePanel.Width = width;
            photoFramePanel.Height = height;

            framePath = new Path();
            framePath.Fill = new SolidColorBrush(fillBrush);
            framePath.Stroke = new SolidColorBrush(strokeBrush);
            framePath.StrokeThickness = strokeThickness;
            FillPath(framePath, photoFramePanel);

            photoFramePanel.Children.Add(framePath);
            parent.Children.Add(photoFramePanel);
        }

        public void ApplyColorScheme(FrameColorScheme scheme)
        {
            FillColor = scheme.FillColor;
            StrokeColor = scheme.StrokeColor;
        }

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("BaseFrame");
            xmlOut.WriteAttributeString("Kind", ((int)FrameKind()).ToString());
            xmlOut.WriteAttributeString("KindName", FrameKindName());
            xmlOut.WriteAttributeString("FillColorA", FillColor.A.ToString());
            xmlOut.WriteAttributeString("FillColorR", FillColor.R.ToString());
            xmlOut.WriteAttributeString("FillColorG", FillColor.G.ToString());
            xmlOut.WriteAttributeString("FillColorB", FillColor.B.ToString());
            xmlOut.WriteAttributeString("StrokeColorA", StrokeColor.A.ToString());
            xmlOut.WriteAttributeString("StrokeColorR", StrokeColor.R.ToString());
            xmlOut.WriteAttributeString("StrokeColorG", StrokeColor.G.ToString());
            xmlOut.WriteAttributeString("StrokeColorB", StrokeColor.B.ToString());
            SaveAdditionalData(xmlOut);
            xmlOut.WriteEndElement();
        }

        public void LoadFromFile(XmlTextReader xmlIn)
        {
            try
            {
                FillColor = Color.FromArgb(Convert.ToByte(xmlIn.GetAttribute("FillColorA")),
                    Convert.ToByte(xmlIn.GetAttribute("FillColorR")),
                    Convert.ToByte(xmlIn.GetAttribute("FillColorG")),
                    Convert.ToByte(xmlIn.GetAttribute("FillColorB")));
                StrokeColor = Color.FromArgb(Convert.ToByte(xmlIn.GetAttribute("StrokeColorA")),
                    Convert.ToByte(xmlIn.GetAttribute("StrokeColorR")),
                    Convert.ToByte(xmlIn.GetAttribute("StrokeColorG")),
                    Convert.ToByte(xmlIn.GetAttribute("StrokeColorB"))); 
                LoadAdditionalData(xmlIn);
            }
            catch (Exception)
            { }
        }

        public static BasePhotoFrame CreatePhotoFrameByID(int id)
        {
            switch (id)
            {
                case BASE_FRAME_CIRCLE:
                    return new CircleFrame();
                case BASE_FRAME_PALAROID:
                    return new PalaroidPhotoFrame();
            }
            return null;
        }

        #endregion

        #region methods

        protected virtual void FillPath(Path path, Panel parent)
        {
        }

        abstract protected void SaveAdditionalData(XmlTextWriter xmlOut);
        abstract protected void LoadAdditionalData(XmlTextReader xmlIn);
        abstract protected int FrameKind();
        abstract protected string FrameKindName();

        #endregion
    }
}
