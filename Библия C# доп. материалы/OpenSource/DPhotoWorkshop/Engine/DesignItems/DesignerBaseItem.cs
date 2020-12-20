using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Xml;
using DPhotoWorkshop.Engine.DesignerHelper;

namespace DPhotoWorkshop.Engine
{
    public abstract class DesignerBaseItem : ContentControl
    {
        public const int EFFECT_DROP_SHADOW = 0;
        public const int EFFECT_BLUR = 1;

        public const int DESIGNER_ITEM_LABEL = 1;

        public DesignerBaseItem()
        {
            Style = FindResource("DesignerItemStyle") as Style;
            Width = 100;
            Height = 20;
        }

        #region properties

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set
            {
                SetValue(IsSelectedProperty, value);
                DesignerCanvas canvas = Parent as DesignerCanvas;
                if (canvas != null)
                    canvas.SelectedItems.Add(this);
            }
        }
        public static readonly DependencyProperty IsSelectedProperty =
          DependencyProperty.Register("IsSelected", typeof(bool), typeof(DesignerBaseItem), new FrameworkPropertyMetadata(false));

        public Color ForegroundColor
        {
            get { return (Color)GetValue(ForegroundColorProperty); }
            set
            {
                SetValue(ForegroundColorProperty, value);
                Foreground = new SolidColorBrush(value);
                if (Content != null)
                    ((Control)Content).Foreground = Foreground;
            }
        }
        public static readonly DependencyProperty ForegroundColorProperty =
          DependencyProperty.Register("ForegroundColor", typeof(Color), typeof(DesignerBaseItem), new FrameworkPropertyMetadata(Colors.Black));

        #endregion

        #region public methods

        abstract protected void SaveAdditionalData(XmlTextWriter xmlOut);
        abstract protected void LoadAdditionalData(XmlTextReader xmlIn);
        abstract protected int DesignerNetworkItemKind();
        abstract protected string DesignerNetworkItemKindName();

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("DesignerItem");
            xmlOut.WriteAttributeString("Kind", ((int)DesignerNetworkItemKind()).ToString());
            xmlOut.WriteAttributeString("KindName", DesignerNetworkItemKindName());
            xmlOut.WriteAttributeString("Left", Canvas.GetLeft(this).ToString());
            xmlOut.WriteAttributeString("Top", Canvas.GetTop(this).ToString());
            xmlOut.WriteAttributeString("Width", Width.ToString());
            xmlOut.WriteAttributeString("Height", Height.ToString());
            xmlOut.WriteAttributeString("FontSize", FontSize.ToString());
            xmlOut.WriteAttributeString("FontColorA", ForegroundColor.A.ToString());
            xmlOut.WriteAttributeString("FontColorR", ForegroundColor.R.ToString());
            xmlOut.WriteAttributeString("FontColorG", ForegroundColor.G.ToString());
            xmlOut.WriteAttributeString("FontColorB", ForegroundColor.B.ToString());
            xmlOut.WriteAttributeString("FontSource", FontFamily.Source);

            RotateTransform rotateTransform = ((ContentControl)this).RenderTransform as RotateTransform;
            if (rotateTransform != null)
                xmlOut.WriteAttributeString("RotateTransformAngle", rotateTransform.Angle.ToString());
            else
                xmlOut.WriteAttributeString("RotateTransformAngle", "0");

            SaveAdditionalData(xmlOut);
            xmlOut.WriteEndElement();
        }

        public void LoadFromFile(XmlTextReader xmlIn)
        {
            Canvas.SetLeft(this, Convert.ToDouble(xmlIn.GetAttribute("Left")));
            Canvas.SetTop(this, Convert.ToDouble(xmlIn.GetAttribute("Top")));
            this.Width = Convert.ToDouble(xmlIn.GetAttribute("Width"));
            this.Height = Convert.ToDouble(xmlIn.GetAttribute("Height"));
            ForegroundColor = Color.FromArgb(
                Convert.ToByte(xmlIn.GetAttribute("FontColorA")),
                Convert.ToByte(xmlIn.GetAttribute("FontColorR")),
                Convert.ToByte(xmlIn.GetAttribute("FontColorG")),
                Convert.ToByte(xmlIn.GetAttribute("FontColorB"))
                );
            ((ContentControl)this).RenderTransform = new RotateTransform(Convert.ToDouble(xmlIn.GetAttribute("RotateTransformAngle")));
            
            FontSize = Convert.ToDouble(xmlIn.GetAttribute("FontSize"));
            FontFamily ff = FontHelpers.GetFontBySource(xmlIn.GetAttribute("FontSource"));
            if (ff != null)
                FontFamily = ff;
            LoadAdditionalData(xmlIn);
        }

        public void ApplyEffect(int effect)
        {
            switch (effect)
            {
                case EFFECT_DROP_SHADOW:
                    Effect = new DropShadowEffect();
                    break;
                case EFFECT_BLUR:
                    Effect = new BlurEffect();
                    break;
            }
        }

        public static DesignerBaseItem CreateDesignerItemByID(int id)
        {
            switch (id)
            {
                case DESIGNER_ITEM_LABEL:
                    return new DesignerLabel();
            }
            return null;
        }

        #endregion
    }
}
