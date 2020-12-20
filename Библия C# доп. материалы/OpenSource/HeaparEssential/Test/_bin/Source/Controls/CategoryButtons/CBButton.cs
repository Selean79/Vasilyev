using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace heaparessential.Controls
{
    [DefaultProperty("Title")]
    [DefaultEvent("PropertyChanged")]
    public class CBButton
    {
        Color transparentColor = Color.Fuchsia;

        #region properties

        string title = "Button";
        [DefaultValue("Button")]
        [Localizable(true)]
        [Category("Main"), Description("Button title that will be show on the button face")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private bool enabled = true;
        [Category("State"), Description("Is control enabled")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        [Category("Main"), Description("Button image that will be show on the button face")]
        protected Image image = null;
        public Image Image
        {
            get { return image; }
            set 
            { 
                image = value;
                transparentColor = BackgroundImageColor(image);
            }
        }

        object tag = "";
        [Category("Main"), Description("User's defined value. You can store here an any value.")]
        [DefaultValue("")]
        public object Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        // font
        [Category("Main"), Description("Button title font.")]
        Font font = SystemFonts.DefaultFont;
        public Font Font
        {
            get { return font; }
            set { font = value; }
        }

        #endregion

        #region methods
        
        /// <summary>
        /// Paint
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="isSelected"></param>
        /// <param name="isHovering"></param>
        public void Paint(Graphics graphics, Point location, Size size, bool isSelected, bool isHovering)
        {
            Brush br;
            Rectangle rect = new Rectangle(location.X, location.Y, size.Width, size.Height);
            if (enabled)
            {
                if (isHovering)
                    br = SystemBrushes.InactiveCaption;
                else
                    if (isSelected)
                        br = SystemBrushes.GradientInactiveCaption;
                    else
                        br = SystemBrushes.Control;
            }
            else
                br = br = SystemBrushes.ControlLight;

            graphics.FillRectangle(br, rect);
            if (isHovering || isSelected)
                graphics.DrawRectangle(SystemPens.Highlight, new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height-1));

            if (title.Length > 0)
                graphics.DrawString(title, font, Brushes.Black, 32, location.Y + size.Height / 2 - font.Height / 2);

            if (image != null)
            {
                ImageAttributes attr = new ImageAttributes();
                attr.SetColorKey(transparentColor, transparentColor);
                
                Rectangle dstRect = new Rectangle(8, location.Y + size.Height / 2 - image.Height / 2, image.Width, image.Height);
                graphics.DrawImage(image, dstRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attr);
            }
        }
        
        /// <summary>
        /// Get background color
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Color BackgroundImageColor(Image image)
        {
            if (image == null)
                return Color.White;
            Bitmap bmp = new Bitmap(image);
            return bmp.GetPixel(0, 0);
        }

        #endregion
    }
}
