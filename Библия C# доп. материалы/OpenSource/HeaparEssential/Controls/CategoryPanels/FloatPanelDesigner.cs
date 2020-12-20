using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace heaparessential.Controls
{
    class FloatPanelDesigner: ControlDesigner
    {
        public override void Initialize(IComponent comp) {
            base.Initialize(comp);
            FloatPanel uc = (FloatPanel)comp;
            EnableDesignMode(uc.controlsPanel, "FloatPanel");
        }
    }
}
