using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace heaparessential.Controls
{
    class FloatPanelCaption: ActivePanel
    {
        #region init
        
        public FloatPanelCaption()
        {
        }

        #endregion

        #region properties

        Image imageBox;
        public Image ImageBox
        {
            get { return imageBox; }
            set 
            { 
                imageBox = value;
                Invalidate();
            }
        }

        #endregion

        #region events

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            if (imageBox != null)
                e.Graphics.DrawImage(imageBox, 4, 4);
        }

        #endregion
    }
}
