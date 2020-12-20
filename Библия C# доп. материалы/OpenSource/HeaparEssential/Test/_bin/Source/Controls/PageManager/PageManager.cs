using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using heaparessential.Collections;
using System.Drawing.Drawing2D;
using heaparessential.Common;

namespace heaparessential.Controls
{
    public enum TabPositionKind { Left, Top, Right, Bottom };

    [System.ComponentModel.DesignerCategory("code")]
    [Designer(typeof(heaparessential.Controls.TabManagerDesigner))]
    [ToolboxBitmap(typeof(PageManager))]
    [DefaultProperty("Pages")]
    public partial class PageManager : UserControl
    {
        #region init

        PageManagerTabs controlPanel = new PageManagerTabs();

        public event EventHandler SelectedPageChanged;

        public PageManager()
        {
            InitializeComponent();

            InactiveColor = SystemColors.ControlLight;

            Controls.Add(controlPanel);
            controlPanel.SelectedPageChanged += new EventHandler(controlPanel_SelectedPageChanged);
            TabPositionChanged();
        }

        #endregion

        #region properties

        /// <summary>
        /// Pages collection
        /// </summary>
        [Category("Page"), Description("Pages list")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PagesCollection Pages
        {
            get { return controlPanel.Pages; }
        }

        /// <summary>
        /// Tab position 
        /// </summary>
        [Category("Page"), Description("Position of pages tabs."), DefaultValue(typeof(TabPositionKind), "Top")]
        public TabPositionKind TabPosition
        {
            get { return controlPanel.TabPosition; }
            set
            {
                controlPanel.TabPosition = value;
                TabPositionChanged();
            }
        }

        /// <summary>
        /// Show pages tabs
        /// </summary>
        [Category("Page"), Description("Show pages tabs.")]
        [DefaultValue(true)]
        bool showTabs = true;
        public bool ShowTabs
        {
            get { return showTabs; }
            set
            {
                showTabs = value;
                controlPanel.Visible = value;
            }
        }

        /// <summary>
        /// Tab panel size
        /// </summary>
        [Category("Page"), Description("Size of tabs panel.")]
        [DefaultValue(true)]
        public Size TabsPanelSize
        {
            get { return controlPanel.Size; }
            set
            {
                controlPanel.Size = value;
                Invalidate();
            }
        }

        [Category("Page"), Description("Draw border on pages.")]
        [DefaultValue(false)]
        public bool DrawBorder
        {
            get { return controlPanel.DrawBorder; }
            set
            {
                controlPanel.DrawBorder = value;
            }
        }

        [Category("Page"), Description("Position of pages tabs.")]
        [DefaultValue(-1)]
        public int SelectedPage
        {
            get { return controlPanel.SelectedPage; }
            set 
            { 
                controlPanel.SelectedPage = value;
                if (SelectedPageChanged != null)
                    SelectedPageChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Selected page name
        /// </summary>
        [Category("Page"), Description("Selected page name"), Editor(typeof(PageSelectorTypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public String SelectedPageName
        {
            get
            {
                if (SelectedPage >= 0 && SelectedPage < Pages.Count)
                    return (Pages[SelectedPage].Name);
                else
                    return "";
            }
            set
            {
                for (int i = 0; i < Pages.Count; i++)
                    if (Pages[i].Name == value)
                    {
                        SelectedPage = i;
                        return;
                    }
            }
        }

        /// <summary>
        /// Active Color
        /// </summary>
        [Category("Decoration"), Description("Active control color"), DefaultValue(typeof(Color), "ButtonFace")]
        public Color ActiveColor
        {
            get { return controlPanel.ActiveColor; }
            set
            {
                controlPanel.ActiveColor = value;
                foreach (Page p in Pages)
                    p.ActiveColor = value;
            }
        }

        [Category("Page"), Description("Allow to close pages"), DefaultValue(true)]
        public bool AllowPageClosing
        {
            get { return controlPanel.AllowPageClosing; }
            set
            {
                controlPanel.AllowPageClosing = value;
            }
        }

        [Category("Decoration"), Description("Active incontrol color"), DefaultValue(typeof(Color), "ControlLight")]
        public Color InactiveColor { get; set; }

        #endregion

        #region private methods

        void controlPanel_SelectedPageChanged(object sender, EventArgs e)
        {
            if (SelectedPageChanged != null)
                SelectedPageChanged(this, new EventArgs());
        }

        void TabPositionChanged()
        {
            switch (TabPosition)
            {
                case TabPositionKind.Top:
                    controlPanel.Dock = DockStyle.Top;
                    controlPanel.Height = 18;
                    break;
                case TabPositionKind.Bottom:
                    controlPanel.Dock = DockStyle.Bottom;
                    controlPanel.Height = 18;
                    break;
                case TabPositionKind.Right:
                    controlPanel.Dock = DockStyle.Right;
                    controlPanel.Width = 100;
                    break;
                case TabPositionKind.Left:
                    controlPanel.Dock = DockStyle.Left;
                    controlPanel.Width = 100;
                    break;
            }

            controlPanel.ShowHideCloseButton();
            controlPanel.Invalidate();
        }

        #endregion

        #region public methods

        public void CheckForMouseClick(Point e)
        {
            controlPanel.CheckForMouseClick(e);
        }

        #endregion
    }
}
