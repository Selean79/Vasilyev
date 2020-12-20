using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace heaparessential.Common
{
    public class HeaparSystemDraw
    {
        public static void DrawDragRectangle(Rectangle newRect, int indent)
        {
            DrawDragRectangles(new Rectangle[]{newRect}, indent);
        }

        public static void DrawDragRectangles(Rectangle[] rects, int indent)
        {
            foreach (Rectangle r in rects)
                ControlPaint.DrawReversibleFrame(r, SystemColors.ButtonFace, FrameStyle.Dashed);
        }
    }
}


