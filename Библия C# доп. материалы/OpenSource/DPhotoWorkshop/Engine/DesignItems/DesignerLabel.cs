    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Xml;

namespace DPhotoWorkshop.Engine
{
    public class DesignerLabel : DesignerBaseItem
    {
        public DesignerLabel():base()
        {            
            label = new Label();
            label.IsHitTestVisible = false;
            Content = label;
        }

        #region properties

        Label label;
        public Label LabelControl
        {
            get { return LabelControl; }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set 
            { 
                SetValue(TextProperty, value);
                label.Content = value;
                try
                {
                    System.Drawing.Size s = System.Windows.Forms.TextRenderer.MeasureText(label.Content.ToString(),
                        new System.Drawing.Font(label.FontFamily.ToString(), (int)label.FontSize, System.Drawing.FontStyle.Regular));
                    this.Width = s.Width + 4;
                    this.Height = s.Height + 4;
                }
                catch
                {
                    return;
                }
            }
        }
        public static readonly DependencyProperty TextProperty =
          DependencyProperty.Register("Text", typeof(string), typeof(DesignerLabel));

        #endregion

        #region overrided methods

        protected override void SaveAdditionalData(XmlTextWriter xmlOut)
        {
            xmlOut.WriteAttributeString("Text", Text);
        }

        protected override void LoadAdditionalData(XmlTextReader xmlIn)
        {
            Text = xmlIn.GetAttribute("Text");
        }

        protected override int DesignerNetworkItemKind()
        {
            return DESIGNER_ITEM_LABEL;
        }

        protected override string DesignerNetworkItemKindName()
        {
            return "Label";
        }

        #endregion
    }
}
