using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace heaparessential.Controls
{
    [System.ComponentModel.DesignerCategory("code")]
    [ToolboxItem(false)]
    [DefaultProperty("Title")]
    public class Page : Panel
    {
        public Page()
        {
            Padding = new Padding(2);
        }

        #region properties

        [Category("Page"), Description("Page title"), DefaultValue("")]
        string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [Category("Page"), Description("Active page color"), DefaultValue(typeof(Color), "ButtonFace")]
        Color activeColor = SystemColors.ButtonFace;
        public Color ActiveColor 
        {
            get { return activeColor; }
            set { activeColor = value; }
        }

        bool drawBorder = true;
        [Category("Page"), Description("Whether to write the border or not"), DefaultValue(true)]
        public bool DrawBorder 
        {
            get { return drawBorder; }
            set 
            {
                if (drawBorder != value)
                {
                    drawBorder = value;
                    Refresh();
                }
            }
        }

        bool canClose = true;
        [Category("Page"), Description("Can the page be closed?"), DefaultValue(true)]
        public bool CanClose
        {
            get { return canClose; }
            set { canClose = value; }
        }

        #endregion

        #region unused properties

        [Browsable(false)]
        public override AnchorStyles Anchor
        {
            get { return base.Anchor; }
            set { base.Anchor = value; }
        }

        [Browsable(false)]
        public override DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = value; }
        }

        #endregion

        #region events
        
        /// <summary>
        /// Paint control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (drawBorder)
            {
                Pen p = new Pen(activeColor, 2);
                e.Graphics.DrawRectangle(p, new Rectangle(1, 1, Width - 2, Height - 2));
            }
        }

        #endregion
    }
}
