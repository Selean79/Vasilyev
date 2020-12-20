using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace DPhotoWorkshop.Engine.Borders
{
    class FrameColorSchemes
    {
        public static FrameColorScheme[] FrameColorSchemesList =
        {
            new FrameColorScheme("Black", Colors.White, Colors.Black),
            new FrameColorScheme("Gray", Colors.Gray, Colors.Black),
            new FrameColorScheme("Red", Colors.Red, Color.FromRgb(127, 0, 0)),
            new FrameColorScheme("Green", Color.FromRgb(76, 255, 0), Color.FromRgb(0, 127, 14))
        };        
    }
}
