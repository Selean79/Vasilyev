using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace DPhotoWorkshop.Engine.DesignerHelper
{
    class FontHelpers
    {
        public static FontFamily GetFontBySource(string source)
        {
            foreach (FontFamily font in Fonts.SystemFontFamilies)
            {
                if (font.Source == source)
                    return font;
            }
            return null;
        }
    }
}
