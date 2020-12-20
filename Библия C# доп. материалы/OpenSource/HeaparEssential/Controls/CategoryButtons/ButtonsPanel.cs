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
    [ToolboxBitmap(typeof(ButtonsPanel))]
    [Description("Buttons panel")]
    [DefaultEvent("Clicked")]
    [DefaultProperty("Buttons")]
    public partial class ButtonsPanel : UserControl
    {
        public delegate void ButtonClicked(Object value, ButtonClickedEventArgs args);

        #region init

        protected static ImageList buttonsImages = HeaparResource.LoadBitmapStrip(Type.GetType("heaparessential.Controls.ButtonsPanel"),
                         "heaparessential.Resources.CPbuttons.png", new Size(imageWidth, imageHeight), new Point(0, 0));

        protected const int imageWidth = 14;
        protected const int imageHeight = 14;

        public event ButtonClicked Clicked;

        public ButtonsPanel()
        {
            buttons = new ButtonCollection();

            InitializeComponent();

            buttons.Cleared += new EventHandler(OnButtonsCleared);
            buttons.Inserted += new CollectionChange(OnButtonInserted);
            buttons.Removed += new CollectionChange(OnButtonRemoved);

            if (showCaptionPanel)
                shift = captionPanel.Height;
            else
                shift = 0;

            StateChanged();
        }

        #endregion

        #region properties

        string title;
        [Category("Panel"), Description("Panel title"), DefaultValue("")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        bool opened = false;
        [Category("Panel"), Description("Is panel opened"), DefaultValue(false)]
        public bool Opened
        {
            get { return opened; }
            set 
            { 
                opened = value;
                StateChanged();
            }
        }

        int buttonsHeight = 24;
        [Category("Panel"), Description("Button height"), DefaultValue(24)]
        public int ButtonsHeight
        {
            get { return buttonsHeight; }
            set { buttonsHeight = value; }
        }

        protected ButtonCollection buttons;
        [Category("Panel"), Description("Buttons of the pannel")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonCollection Buttons
        {
            get { return buttons; }
        }

        int shift;
        [Category("Panel"), Description("Must the panel caption be shown"), DefaultValue(true)]
        bool showCaptionPanel = true;
        public bool ShowCaptionPanel 
        { 
            get { return showCaptionPanel; }
            set 
            { 
                showCaptionPanel = value;
                captionPanel.Visible = showCaptionPanel;

                if (showCaptionPanel)
                    shift = captionPanel.Height;
                else
                    shift = 0;

                StateChanged();
            } 
        }

        #endregion

        #region nonbrowsable properties

        [Browsable(false)]
        int focusedButton = -1;
        public int FocusedButton
        {
            get { return focusedButton; }
        }

        [Browsable(false)]
        int selectedButtonIndex = -1;
        public int SelectedButtonIndex
        {
            get { return selectedButtonIndex; }
            set
            {
                selectedButtonIndex = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public CBButton SelectedButton
        {
            get
            {
                if (selectedButtonIndex == -1)
                    return null;
                else
                    return buttons[selectedButtonIndex];
            }
        }

        #endregion

        #region methods

        /// <summary>
        /// Caption panel paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void captionPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, captionPanel.Width, captionPanel.Height);
            Brush brush = new LinearGradientBrush(rect, SystemColors.InactiveCaption, SystemColors.GradientInactiveCaption, 90f);

            e.Graphics.FillRectangle(brush, rect);
            brush.Dispose();

            e.Graphics.DrawString(title, Font, Brushes.Black, 16, (captionPanel.Height - Font.Height) / 2);
        }

        /// <summary>
        /// Button panel paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {
            if (opened)
                e.Graphics.DrawImage(buttonsImages.Images[0], 0, 0, 9, 9);
            else
                e.Graphics.DrawImage(buttonsImages.Images[1], 0, 0, 9, 9);
        }

        /// <summary>
        /// Button panel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPanel_Click(object sender, EventArgs e)
        {
            Opened = ! Opened;            
        }

        /// <summary>
        /// State has been changed
        /// </summary>
        private void StateChanged()
        {
            SuspendLayout();
            Height = 0;
            if (opened)
            {
                Height = (buttonsHeight * buttons.Count);
            }

            if (showCaptionPanel)
                Height += captionPanel.Height;

            ResumeLayout();
            buttonPanel.Invalidate();
        }

        /// <summary>
        /// Buttons panel paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonsPanel_Paint(object sender, PaintEventArgs e)
        {
            if (opened)
            {
                for (int i = 0; i < buttons.Count; i++)
                    buttons[i].Paint(e.Graphics, new Point(0, shift + i * buttonsHeight), new Size(Width, buttonsHeight), (i == selectedButtonIndex), false);
            }
        }
        
        /// <summary>
        /// Mouse move event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                int index = (e.Location.Y - shift - 1) / (buttonsHeight + 1);
                if (index >= 0 && index < buttons.Count)
                {
                    if (focusedButton == index)
                        return;

                    Graphics g = Graphics.FromHwnd(this.Handle);
                    if (focusedButton >= 0)
                    {
                        buttons[focusedButton].Paint(g, new Point(0, shift + focusedButton * buttonsHeight), new Size(Width, buttonsHeight), (focusedButton == selectedButtonIndex), false);
                    }

                    focusedButton = index;
                    buttons[focusedButton].Paint(g, new Point(0, shift + focusedButton * buttonsHeight), new Size(Width, buttonsHeight), false, true);
                    g.Dispose();

                }
            }
        }

        /// <summary>
        /// Mouse leave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonsPanel_MouseLeave(object sender, EventArgs e)
        {
            if (focusedButton >= 0)
            {
                Graphics g = Graphics.FromHwnd(this.Handle);
                buttons[focusedButton].Paint(g, new Point(0, shift + focusedButton * buttonsHeight), new Size(Width, buttonsHeight), (focusedButton == selectedButtonIndex), false);
                focusedButton = -1;
                g.Dispose();
            }
        }

        /// <summary>
        /// Click on panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonsPanel_Click(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        /// <summary>
        /// Selected button changed
        /// </summary>
        void SelectionChanged()
        {
            if (selectedButtonIndex == focusedButton)
                return;

            Graphics g = Graphics.FromHwnd(this.Handle);
            if (selectedButtonIndex >= 0)
            {
                buttons[selectedButtonIndex].Paint(g, new Point(0, shift + selectedButtonIndex * buttonsHeight), new Size(Width, buttonsHeight), false, false);
            }

            selectedButtonIndex = focusedButton;
            buttons[selectedButtonIndex].Paint(g, new Point(0, shift + selectedButtonIndex * buttonsHeight), new Size(Width, buttonsHeight), true, false);
            g.Dispose();

            if (Clicked != null)
                Clicked(this, new ButtonClickedEventArgs(selectedButtonIndex));
        }

        public void Unselect()
        {
            if (selectedButtonIndex >= 0)
            {
                Graphics g = Graphics.FromHwnd(this.Handle);
                buttons[selectedButtonIndex].Paint(g, new Point(0, shift + selectedButtonIndex * buttonsHeight), new Size(Width, buttonsHeight), false, false);
                selectedButtonIndex = -1;
                g.Dispose();
            }
        }

        private void captionPanel_DoubleClick(object sender, EventArgs e)
        {
            Opened = ! Opened;
        }

        #endregion

        #region events 
        
        protected void OnButtonsCleared(Object o, EventArgs e)
        {
            StateChanged();
        }

        protected void OnButtonInserted(Object o, CollectionChangingEventArgs e)
		{
            StateChanged();
		}

        protected void OnButtonRemoved(Object o, CollectionChangingEventArgs e)
        {
            StateChanged();
        }        

        #endregion

    }
}
