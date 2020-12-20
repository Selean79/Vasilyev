using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using heaparessential.Collections;
using heaparessential.Common;

namespace heaparessential.Controls
{
    [System.ComponentModel.DesignerCategory("code")]
    public partial class PageManagerTabs : ActivePanel
    {
        #region init

        public event EventHandler SelectedPageChanged;
        public delegate void PageListChanged (object sender, CollectionChangingEventArgs args);
        public event PageListChanged PageRemoving;

        const int CONTROL_BUTTON_WIDTH = 44;
        const int CONTROL_BUTTON_HEIGHT = 14;
        const int TAB_SPACE_SIZE = 4;

        bool nextButtonEnabled = false;

        int offset = 0;

        Button closeButton = new Button();
        Button leftButton = new Button();
        Button rightButton = new Button();

        protected static ImageList internalImages;

        const int imageButtonWidth = 11;
        const int imageButtonHeight = 11;

        public PageManagerTabs()
        {
            internalImages = HeaparResource.LoadBitmapStrip(Type.GetType("heaparessential.Controls.PageManager"),
                "heaparessential.Resources.ImagesTabControl.bmp",
                new Size(imageButtonWidth, imageButtonHeight),
                new Point(0, 0));

            InitializeComponent();

            InitControlPanel();

            pagesCollection = new PagesCollection();
            pagesCollection.Cleared += new EventHandler(OnTabCollectionCleared);
            pagesCollection.Inserted += new CollectionChange(OnTabCollectionInserted);
            pagesCollection.Removed += new CollectionChange(OnTabCollectionRemoved);
            pagesCollection.Removing += new CollectionChange(OnTabCollectionRemoving);

            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        void OnTabCollectionRemoving(object sender, CollectionChangingEventArgs e)
        {
            if (PageRemoving != null)
                PageRemoving(sender, e);
        }

        #endregion

        #region properties

        TabPositionKind tabPosition = TabPositionKind.Top;
        public TabPositionKind TabPosition
        {
            get { return tabPosition; }
            set
            {
                tabPosition = value;
            }
        }

        PagesCollection pagesCollection;
        public PagesCollection Pages
        {
            get { return pagesCollection; }
        }

        [Category("Page"), Description("Draw border on pages.")]
        [DefaultValue(false)]
        bool drawBorder = false;
        public bool DrawBorder
        {
            get { return drawBorder; }
            set
            {
                if (drawBorder != value)
                {
                    drawBorder = value;
                    foreach (Page page in Pages)
                        page.DrawBorder = value;
                    Invalidate();
                }
            }
        }

        bool allowPageClosing = true;
        [Category("Page"), Description("Allow to close pages"), DefaultValue(true)]
        public bool AllowPageClosing
        {
            get { return allowPageClosing; }
            set
            {
                allowPageClosing = value;
                if (allowPageClosing)
                    ShowHideCloseButton();
                else
                    ShowHideCloseButton();
            }
        }

        /// <summary>
        /// Active Color
        /// </summary>
        [Category("Decoration"), Description("Active control color"), DefaultValue(typeof(Color), "ButtonFace")]
        Color activeColor = SystemColors.ActiveCaption;
        public Color ActiveColor
        {
            get { return activeColor; }
            set
            {
                activeColor = value;
                foreach (Page p in pagesCollection)
                    p.ActiveColor = value;
            }
        }

        Color selectedForeColor = Color.FromArgb(252, 162, 85);
        public Color SelectedForeColor
        {
            get { return selectedForeColor; }
            set { selectedForeColor = value; }
        }        

        /// <summary>
        /// Selected page
        /// </summary>
        [Category("Page"), Description("Position of pages tabs.")]
        [DefaultValue(-1)]
        int selectedPage = -1;
        public int SelectedPage
        {
            get { return selectedPage; }
            set
            {
                if (value < -1 || value >= pagesCollection.Count)
                {
                    selectedPage = pagesCollection.Count - 1;
                }

                selectedPage = value;

                if (value >= 0)
                    pagesCollection[value].BringToFront();

                ShowHideCloseButton();
                Invalidate();

                if (SelectedPageChanged != null)
                    SelectedPageChanged(this, new EventArgs());
            }
        }

        [DefaultValue(-1)]
        int hoveredPage = -1;
        public int HoveredPage
        {
            get { return hoveredPage; }
            set { hoveredPage = value; }
        }

        #endregion

        #region overriden

        protected override void OnMouseUp(MouseEventArgs e)
        {
            CheckForMouseClick(e.Location);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            int tabIndex = GetTabAt(e.Location);
            if (tabIndex != hoveredPage)
            {
                hoveredPage = tabIndex;
                Refresh();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            ShowHideCloseButton();
            Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hoveredPage = -1;
            Refresh();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Color currColor;
            LinearGradientBrush captionBrush;
            int CurrOffset = 1;
            SizeF titleSize;
            Font currFont;
            int selOffset;
            Color captionColor;

            for (int i = offset; i < Pages.Count; i++)
            {
                if (i == selectedPage)
                {
                    captionColor = SelectedForeColor;
                    currColor = ActiveColor;
                    currFont = Font;
                    selOffset = 1;
                } else
                {
                    captionColor = ForeColor;
                    currColor = BackColor;
                    currFont = Font;
                    selOffset = 2;
                }

                if (i == hoveredPage)
                    captionColor = Color.FromArgb(252, 162, 85);

                titleSize = e.Graphics.MeasureString(Pages[i].Title, Font);
                int tabHeight = (int)titleSize.Height + TAB_SPACE_SIZE;

                if (!CheckTabOffset(i, CurrOffset, ref titleSize))
                    return;

                // create gradient brush
                switch (tabPosition)
                {
                    case TabPositionKind.Top:
                        captionBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), i == selectedPage ? Color.White : ActiveColor, BackColor);
                        e.Graphics.FillRectangle(captionBrush, new Rectangle(CurrOffset, selOffset, (int)titleSize.Width + TAB_SPACE_SIZE, Height + 1));
                        e.Graphics.DrawRectangle(new Pen(ActiveColor), new Rectangle(CurrOffset, selOffset, (int)titleSize.Width + TAB_SPACE_SIZE, Height + 1));
                        e.Graphics.DrawString(Pages[i].Title, currFont, new SolidBrush(captionColor), new PointF(CurrOffset + 2, 3));
                        CurrOffset += (int)titleSize.Width + TAB_SPACE_SIZE;
                        break;
                    case TabPositionKind.Bottom:
                        captionBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), BackColor, i == selectedPage ? Color.White : ActiveColor);
                        e.Graphics.FillRectangle(captionBrush, new Rectangle(CurrOffset, -selOffset - 1, (int)titleSize.Width + TAB_SPACE_SIZE, Height));
                        e.Graphics.DrawRectangle(new Pen(ActiveColor), new Rectangle(CurrOffset, -selOffset - 1, (int)titleSize.Width + TAB_SPACE_SIZE, Height));
                        e.Graphics.DrawString(Pages[i].Title, currFont, new SolidBrush(captionColor), new PointF(CurrOffset + 2, 1));
                        CurrOffset += (int)titleSize.Width + TAB_SPACE_SIZE;
                        break;
                    case TabPositionKind.Left:
                        captionBrush = new LinearGradientBrush(new Point(0, 0), new Point(Width, 0), i == selectedPage ? Color.White : ActiveColor, BackColor);
                        e.Graphics.FillRectangle(captionBrush, new Rectangle(selOffset, CurrOffset, Width - selOffset, (int)titleSize.Height + TAB_SPACE_SIZE));
                        e.Graphics.DrawRectangle(new Pen(ActiveColor), new Rectangle(selOffset, CurrOffset, Width - selOffset, (int)titleSize.Height + TAB_SPACE_SIZE));
                        e.Graphics.DrawString(Pages[i].Title, currFont, new SolidBrush(captionColor),
                            new RectangleF(TAB_SPACE_SIZE, CurrOffset + 2, Width, tabHeight));
                        CurrOffset += tabHeight;
                        break;
                    case TabPositionKind.Right:
                        captionBrush = new LinearGradientBrush(new Point(0, 0), new Point(Width, 0), BackColor, i == selectedPage ? Color.White : ActiveColor);
                        e.Graphics.FillRectangle(captionBrush, new Rectangle(-1, CurrOffset, Width - selOffset, (int)titleSize.Height + TAB_SPACE_SIZE));
                        e.Graphics.DrawRectangle(new Pen(ActiveColor), new Rectangle(-1, CurrOffset, Width - selOffset, (int)titleSize.Height + TAB_SPACE_SIZE));
                        e.Graphics.DrawString(Pages[i].Title, currFont, new SolidBrush(captionColor),
                            new RectangleF(2, CurrOffset + 2, Width, tabHeight));
                        CurrOffset += tabHeight;
                        break;
                }
                nextButtonEnabled = false;
                rightButton.ImageIndex = 3;
            }
        }

        #endregion

        #region events

        void closeButton_Click(object sender, EventArgs e)
        {
            if (SelectedPage >= 0 && SelectedPage < Pages.Count)
            {
                Page p = Pages[SelectedPage];
                Pages.RemoveAt(SelectedPage);
                p.Dispose();
                Refresh();
            }
        }

        void leftButton_Click(object sender, EventArgs e)
        {
            if (offset > 0)
            {
                offset--;
                Refresh();

                TestLeftButton();
            }
        }

        void rightButton_Click(object sender, EventArgs e)
        {
            if (offset < Pages.Count - 1)
            {
                offset++;
                Refresh();
                TestLeftButton();
                ShowHideCloseButton();
            }
        }

        protected void OnTabCollectionCleared(Object o, EventArgs e)
        {
            foreach (Control c in Controls)
                Controls.Remove(c);
            selectedPage = -1;
        }

        protected void OnTabCollectionInserted(Object o, CollectionChangingEventArgs e)
        {
            Page page = (Page)e.Value;
            page.Dock = DockStyle.Fill;
            page.ActiveColor = ActiveColor;
            page.DrawBorder = drawBorder;
            Parent.Controls.Add((Page)e.Value);
            SelectedPage = Pages.Count - 1;
            page.BringToFront();
            ShowHideCloseButton();
        }

        protected void OnTabCollectionRemoved(Object o, CollectionChangingEventArgs e)
        {
            Controls.Remove((Page)e.Value);
            if (e.Index <= selectedPage)
            {
                SelectedPage = SelectedPage - 1;
            }
            Refresh();
        }


        #endregion

        #region private

        void InitControlPanel()
        {
            InitButton(closeButton);
            InitButton(leftButton);
            InitButton(rightButton);

            closeButton.ImageIndex = 4;
            leftButton.ImageIndex = 0;
            rightButton.ImageIndex = 2;

            closeButton.Click += new EventHandler(closeButton_Click);
            leftButton.Click += new EventHandler(leftButton_Click);
            rightButton.Click += new EventHandler(rightButton_Click);

            ShowHideCloseButton();
            TestLeftButton();
        }

        bool CheckTabOffset(int i, int CurrOffset, ref SizeF titleSize)
        {
            // check for width
            if (tabPosition == TabPositionKind.Top || tabPosition == TabPositionKind.Bottom)
            {
                if ((CurrOffset + titleSize.Width) > (Width - CONTROL_BUTTON_WIDTH))
                {
                    if (i > offset)
                    {
                        rightButton.ImageIndex = 2;
                        nextButtonEnabled = true;
                        return false;
                    }
                    else
                        titleSize.Width = Width - CONTROL_BUTTON_WIDTH;
                }
            }
            else
            {
                if ((CurrOffset + titleSize.Height) > (Height - CONTROL_BUTTON_HEIGHT))
                {
                    if (i > offset)
                    {
                        rightButton.ImageIndex = 2;
                        nextButtonEnabled = true;
                        return false;
                    }
                    else
                        titleSize.Height = Height - CONTROL_BUTTON_HEIGHT;
                }
            }
            return true;
        }

        void InitButton(Button button)
        {
            Controls.Add(button);
            button.Height = 12;
            button.Width = 12;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Text = "";
            button.ImageList = internalImages;
        }

        #endregion

        #region public

        public void TestLeftButton()
        {
            if (offset == 0)
            {
                leftButton.Enabled = false;
                leftButton.ImageIndex = 1;
            }
            else
            {
                leftButton.Enabled = true;
                leftButton.ImageIndex = 0;
            }
        }

        public void ShowHideCloseButton()
        {
            if (SelectedPage >= 0)
                closeButton.Visible = allowPageClosing && (Pages[SelectedPage].CanClose);
            else
                closeButton.Visible = false;

            int offset = 0;
            if (allowPageClosing)
                offset = closeButton.Width;

            if (tabPosition == TabPositionKind.Top || tabPosition == TabPositionKind.Bottom)
            {
                closeButton.Top = 4;
                rightButton.Top = 4;
                leftButton.Top = 4;

                closeButton.Left = Width - closeButton.Width - 2;
                rightButton.Left = Width - rightButton.Width - offset - 2;
                leftButton.Left = Width - rightButton.Width - leftButton.Width - offset - 2;
            }
            else
            {
                leftButton.Left = 4;
                rightButton.Left = leftButton.Width + 8;
                closeButton.Left = leftButton.Width + rightButton.Width + 12;

                closeButton.Top = Height - closeButton.Height - 2;
                rightButton.Top = Height - rightButton.Height - 2;
                leftButton.Top = Height - rightButton.Height - 2;
            }
            
            rightButton.Enabled = nextButtonEnabled;
        }

        public void CheckForMouseClick(Point e)
        {
            int tabindex = GetTabAt(e);
            if (tabindex >= 0)
                SelectedPage = tabindex;
        }

        public int GetTabAt(Point e)
        {
            int CurrOffset = 2;
            SizeF titleSize;
            int SelOffset;
            Graphics g = Graphics.FromHwnd(this.Handle);

            for (int i = offset; i < Pages.Count; i++)
            {
                // check for selection
                if (i == selectedPage)
                    SelOffset = 0;
                else
                    SelOffset = 2;
                titleSize = g.MeasureString(Pages[i].Title, Font);

                // check horizontal 
                if (tabPosition == TabPositionKind.Top || tabPosition == TabPositionKind.Bottom)
                {
                    if (e.X > CurrOffset && e.X < CurrOffset + (int)titleSize.Width + 4 &&
                        e.Y > SelOffset && e.Y < Height)
                        return i;
                    CurrOffset += (int)titleSize.Width + 5;
                }

                // check vertical
                if (tabPosition == TabPositionKind.Left || tabPosition == TabPositionKind.Right)
                {
                    if (e.X > SelOffset && e.X < SelOffset + Width - SelOffset &&
                        e.Y > CurrOffset && e.Y < CurrOffset + (int)titleSize.Height + 4)
                        return i;
                    CurrOffset += (int)titleSize.Height + 4;
                }
            }
            return -1;
        }

        #endregion
    }
}
