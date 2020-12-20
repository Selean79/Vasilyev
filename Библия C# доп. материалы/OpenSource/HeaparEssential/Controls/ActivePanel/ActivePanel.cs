using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace heaparessential.Controls
{
    public enum TextAligment { Left, Center, Right };

    [System.ComponentModel.DesignerCategory("code")]
    [DefaultProperty("AnimationSpeed")]
    [Description("It is a panel with the color animation when the mouse cursor is hover over panel")]
    [ToolboxBitmap(typeof(ActivePanel))]
    public partial class ActivePanel : Panel
    {
        #region init

        private Timer animationTimer = new Timer();
        bool isLeaving;
        bool isActive = false;
        Color currColor;
        int currAnimationStep = 0;

        public ActivePanel()
        {
            InitializeComponent();

            animationTimer.Interval = 1;
            animationTimer.Tick += new EventHandler(animationTimer_Tick);

            currColor = passiveColor;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        #endregion

        #region properties

        Color hoverColor = SystemColors.ActiveCaption;
        [Category("Active"), Description("it is a color of control when the mouse pointer on control")]
        [DefaultValue(typeof(Color), "ActiveCaption")]
        public Color HoverColor
        {
            get { return hoverColor; }
            set
            {
                hoverColor = value;
                if (isActive)
                {
                    currColor = hoverColor;
                    Refresh();
                }
            }
        }

        Color topHighlightColor = SystemColors.Window;
        [Category("Active"), Description("It is an active color for gradient effect of the top of panel")]
        [DefaultValue(typeof(Color), "Window")]
        public Color TopHighlightColor
        {
            get { return topHighlightColor; }
            set { topHighlightColor = value; }
        }

        Color bottomHighlightColor = SystemColors.Window;
        [Category("Active"), Description("It is an active color for gradient effect of the bottom of panel")]
        [DefaultValue(typeof(Color), "Window")]
        public Color BottomHighlightColor
        {
            get { return bottomHighlightColor; }
            set { bottomHighlightColor = value; }
        }

        Color passiveColor = SystemColors.InactiveCaption;
        [Category("Active"), Description("It is a color of control when the mouse pointer not on control")]
        [DefaultValue(typeof(Color), "InactiveCaption")]
        public Color PassiveColor
        {
            get { return passiveColor; }
            set
            {
                passiveColor = value;
                if (!isActive)
                {
                    currColor = passiveColor;
                    Refresh();
                }
            }
        }

        int gradientHeight = 30;
        [Category("Active"), Description("It is a size of the gradient field")]
        [DefaultValue(30)]
        public int GradientHeight
        {
            get { return gradientHeight; }
            set { gradientHeight = value; }
        }

        int animationSpeed = 100;
        [Category("Active"), Description("How faster will the animation play")]
        [DefaultValue(100)]
        public int AnimationSpeed
        {
            get { return animationSpeed; }
            set { animationSpeed = value; }
        }

        bool animation = true;
        [Category("Active"), Description("How faster will the animation play")]
        [DefaultValue(true)]
        public bool Animation
        {
            get { return animation; }
            set { animation = value; }
        }

        string topTitle = "";
        [Category("Title"), Description("It is a top title")]
        [DefaultValue("")]
        public string TopTitle
        {
            get { return topTitle; }
            set { topTitle = value; }
        }

        Point topTitleOffset = new Point(8, 8);
        [Category("Title"), Description("It is a offset of the top title")]
        public Point TopTitleOffset
        {
            get { return topTitleOffset; }
            set { topTitleOffset = value; }
        }

        TextAligment topTitleAlign = TextAligment.Left;
        [DefaultValue(typeof(TextAligment), "Left")]
        [Category("Title"), Description("It is a offset of the top title")]
        public TextAligment TopTitleAlign
        {
            get { return topTitleAlign; }
            set { topTitleAlign = value; }
        }

        string bottomTitle = "";
        [Category("Title"), Description("It is a bottom title")]
        [DefaultValue("")]
        public string BottomTitle
        {
            get { return bottomTitle; }
            set { bottomTitle = value; }
        }

        Point bottomTitleOffset = new Point(8, 8);
        [Category("Title"), Description("It is a offset of the bottom title")]
        public Point BottomTitleOffset
        {
            get { return bottomTitleOffset; }
            set { bottomTitleOffset = value; }
        }

        TextAligment bottomTitleAlign = TextAligment.Left;
        [Category("Title"), Description("It is a offset of the bottom title")]
        [DefaultValue(typeof(TextAligment), "Left")]
        public TextAligment BottomTitleAlign
        {
            get { return bottomTitleAlign; }
            set { bottomTitleAlign = value; }
        }

        [Category("Title"), Description("It is a font parameters of the panel title")]
        public new Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }

        #endregion

        #region methods

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!Animation)
                return;
            isLeaving = false;
            currAnimationStep = 0;
            isActive = true;
            animationTimer.Start();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!Animation)
                return;
            isLeaving = true;
            currAnimationStep = 0;
            isActive = false;
            animationTimer.Start();
            base.OnMouseLeave(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            LinearGradientBrush topLinearBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, gradientHeight), topHighlightColor, currColor);
            LinearGradientBrush bottomLinearBrush = new LinearGradientBrush(new Point(0, Height - gradientHeight), new Point(0, Height), currColor, bottomHighlightColor);

            e.Graphics.FillRectangle(new SolidBrush(currColor), 0, gradientHeight, Width, Height - gradientHeight * 2);
            e.Graphics.FillRectangle(topLinearBrush, 0, 0, Width, gradientHeight);
            e.Graphics.FillRectangle(bottomLinearBrush, 0, Height - gradientHeight, Width, gradientHeight);

            if (topTitle != "")
            {
                DrawCaption(e.Graphics, topTitle, topTitleAlign, topTitleOffset.Y, topTitleOffset.X);
            }

            if (bottomTitle != "")
            {
                DrawCaption(e.Graphics, bottomTitle, bottomTitleAlign, (int)(Height - bottomTitleOffset.Y - e.Graphics.MeasureString(bottomTitle, Font).Height), bottomTitleOffset.X);
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        void DrawCaption(Graphics g, string title, TextAligment ta, int yoffset, int xoffset)
        {
            int x = 0;

            switch (ta)
            {
                case TextAligment.Left:
                    x = xoffset;
                    break;
                case TextAligment.Right:
                    x = (int)(Width - xoffset - g.MeasureString(TopTitle, Font).Width);
                    break;
                case TextAligment.Center:
                    x = ((int)(Width - g.MeasureString(TopTitle, Font).Width) - xoffset) / 2;
                    break;
            }

            g.DrawString(title, Font, new SolidBrush(ForeColor), x, yoffset);
        }

        void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animationSpeed == currAnimationStep)
            {
                animationTimer.Stop();
                return;
            }

            int r = currColor.R;
            int g = currColor.G;
            int b = currColor.B;
            Color endColor;

            if (isLeaving)
                endColor = passiveColor;
            else
                endColor = hoverColor;

            r = r - (r - endColor.R) / (animationSpeed - currAnimationStep);
            g = g - (g - endColor.G) / (animationSpeed - currAnimationStep);
            b = b - (b - endColor.B) / (animationSpeed - currAnimationStep);

            r = Math.Max(Math.Min(r, 255), 0);
            g = Math.Max(Math.Min(g, 255), 0);
            b = Math.Max(Math.Min(b, 255), 0);

            currColor = Color.FromArgb(r, g, b);
            if (currColor.ToArgb() == endColor.ToArgb())
                animationTimer.Stop();

            currAnimationStep++;
            this.Refresh();
        }

        #endregion
    }
}
