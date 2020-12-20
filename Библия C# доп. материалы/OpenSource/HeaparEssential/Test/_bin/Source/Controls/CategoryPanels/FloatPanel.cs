using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using heaparessential.Common;

namespace heaparessential.Controls
{
    [Designer(typeof(FloatPanelDesigner))]
    [DefaultProperty("Title")]
    public partial class FloatPanel : UserControl
    {
        #region init

        protected static ImageList buttonsImages = HeaparResource.LoadBitmapStrip(Type.GetType("heaparessential.Controls.ButtonsPanel"),
                         "heaparessential.Resources.CPbuttons.png", new Size(imageWidth, imageHeight), new Point(0, 0));
        protected const int imageWidth = 14;
        protected const int imageHeight = 14;

        public FloatPanel()
        {
            InitializeComponent();

            panelHeight = Height - controlActivePanel.Height;
            controlActivePanel.ImageBox = buttonsImages.Images[0];
            opened = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        #endregion
        
        #region properties

        int panelHeight;
        [Category("FloatPanel"), Description("It is an height of active panel")]
        public int PanelHeight
        {
            get { return panelHeight; }
            set
            {
                panelHeight = value;
                if (opened)
                    Height = panelHeight + controlActivePanel.Height;
            }
        }

        [Category("FloatPanel"), Description("It is an active panel title"), DefaultValue("")]
        public string Title 
        {
            get { return controlActivePanel.TopTitle; }  
            set { controlActivePanel.TopTitle = value; } 
        }

        [Category("FloatPanel"), Description("It float panel opened"), DefaultValue(true)]
        bool opened = true;
        public bool Opened
        {
            get { return opened; }
            set 
            { 
                opened = value;
                if (opened)
                {
                    controlActivePanel.ImageBox = buttonsImages.Images[0];
                    Height = panelHeight + controlActivePanel.Height;
                }
                else
                {
                    controlActivePanel.ImageBox = buttonsImages.Images[1];
                    Height = controlActivePanel.Height;
                }
            }
        }

        [Category("FloatPanel"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("It is a read only property that shows you the designer panel control. ")]
        public Panel ControlsPanel { get { return controlsPanel; } }

        #endregion

        #region base properties

        [Browsable(false)]
        public new Size Size
        {
            get { return base.Size; }
            set { base.Size = value; }
        }

        [Browsable(false)]
        public new DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = value; }
        }

        [Browsable(false)]
        public new int Width
        {
            get { return base.Width; }
            set { base.Width = value; }
        }

        [Browsable(false)]
        public new int Height
        {
            get { return base.Height; }
            set { base.Height = value; }
        }

        #endregion

        #region methods

        #endregion

        #region events

        protected override Control.ControlCollection CreateControlsInstance()
        {
            return base.CreateControlsInstance();
        }

        private void controlActivePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Opened = !Opened;
        }

        private void buttonPictureBox_Click(object sender, EventArgs e)
        {
            Opened = !Opened;
        }

        #endregion
    }
}
