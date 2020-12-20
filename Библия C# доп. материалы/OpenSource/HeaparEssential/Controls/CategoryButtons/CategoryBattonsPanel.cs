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
    [ToolboxBitmap(typeof(CategoryBattonsPanel))]
    [Description("It is a panel to categorize buttons")]
    [DefaultProperty("Categories")]
    public partial class CategoryBattonsPanel : UserControl
    {
        #region init

        public CategoryBattonsPanel()
        {
            categories = new CategoryCollection();
            categories.Cleared += new EventHandler(OnCategoryCleared);
            categories.Inserted += new CollectionChange(OnCategoryInserted);
            categories.Removed += new CollectionChange(OnCategoryRemoved);

            InitializeComponent();
        }

        #endregion

        #region properties

        CategoryCollection categories;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CategoryCollection Categories
        {
            get { return categories; }
        }

        ButtonsPanel selectedPanel;
        [Browsable(false)]
        public ButtonsPanel SelectedPanel
        {
            get { return selectedPanel; }
            set 
            { 
                selectedPanel = value; 
                if (selectedPanel == null)
                    foreach (ButtonsPanel bp in categories)
                            bp.Unselect();
            }
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
            ButtonsPanel panel = (ButtonsPanel)e.Value;
            panel.Clicked += OnSelectionChanged;
            panel.Dock = DockStyle.Top;
            Controls.Add((ButtonsPanel)e.Value);
            panel.BringToFront();
        }

        protected void OnCategoryRemoved(Object o, CollectionChangingEventArgs e)
        {
            Controls.Remove((ButtonsPanel)e.Value);
        }

        protected void OnSelectionChanged(object value, ButtonClickedEventArgs args)
        {
            foreach (ButtonsPanel bp in categories)
                if (bp.Name == ((ButtonsPanel)value).Name)
                    selectedPanel = bp;
                else
                    bp.Unselect();
        }

        #endregion
    }
}
