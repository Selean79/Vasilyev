using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using heaparessential.Collections;
using heaparessential.Common;

namespace heaparessential.Controls
{
    [System.ComponentModel.DesignerCategory("code")]
    [ToolboxBitmap(typeof(CategoryPanels))]
    [DefaultProperty("Panels")]
    public partial class CategoryPanels : UserControl
    {
        #region init

        public CategoryPanels()
        {
            panels = new FloatPanelCollection();
            panels.Cleared += new EventHandler(OnCategoryCleared);
            panels.Inserted += new CollectionChange(OnCategoryInserted);
            panels.Removed += new CollectionChange(OnCategoryRemoved);
            AutoScroll = true;

            InitializeComponent();
        }

        #endregion

        #region properties

        FloatPanelCollection panels;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public FloatPanelCollection Panels
        {
            get { return panels; }
        }

        #endregion

        #region methods

        #endregion

        #region events

        protected void OnCategoryCleared(Object o, EventArgs e)
        {
            Controls.Clear();
        }

        protected void OnCategoryInserted(Object o, CollectionChangingEventArgs e)
        {
            Panel clientPanel = new Panel();
            clientPanel.Dock = DockStyle.Fill;
            FloatPanel panel = (FloatPanel)e.Value;
            panel.Dock = DockStyle.Top;
            Controls.Add((FloatPanel)e.Value);
            panel.BringToFront();
        }

        protected void OnCategoryRemoved(Object o, CollectionChangingEventArgs e)
        {
            Controls.Remove((FloatPanel)e.Value);
        }

        #endregion
    }
}
