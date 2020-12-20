using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace heaparessential.Controls
{
    [ToolboxItem(false)]
    public class FloatDesignPanel : Panel
    {
        #region base properties

        [Browsable(false)]
        public new DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = value; }
        }

        [Browsable(false)]
        public new AnchorStyles Anchor
        {
            get { return base.Anchor; }
            set { base.Anchor = value; }
        }

        #endregion
    }
}
