using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Windows.Controls.Ribbon;
using System.Windows.Media;
using System.Windows;

namespace DPhotoWorkshop.Engine.DesignerHelpers
{
    public class FontNamesList : System.Collections.Generic.List<RibbonComboBoxItem>
    {
        public FontNamesList()
        {
            foreach (FontFamily font in Fonts.SystemFontFamilies)
            {
                RibbonComboBoxItem item = new RibbonComboBoxItem();
                item.FontFamily = font;
                item.FontSize = 12;
                item.Content = font.ToString();
                base.Add(item);
            }
        }
    }
}
