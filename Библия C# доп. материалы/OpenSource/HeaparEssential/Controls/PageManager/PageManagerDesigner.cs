using System;
using System.Collections.Generic;
using System.Text;
using heaparessential.Controls;
using System.ComponentModel.Design;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace heaparessential.Controls
{
    class TabManagerDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        const int WM_LBUTTONDOWN = 0x0201;
        private ISelectionService _selectionService = null;

        public override ICollection AssociatedComponents
        {
            get
            {
                if (base.Control is PageManager)
                    return ((PageManager)base.Control).Pages;
                else
                    return base.AssociatedComponents;
            }
        }

        public ISelectionService SelectionService
        {
            get
            {
                if (_selectionService == null)
                {
                    _selectionService = (ISelectionService)GetService(typeof(ISelectionService));
                }

                return _selectionService;
            }
        }

        protected override bool DrawGrid
        {
            get { return false; }
        }
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == (int)WM_LBUTTONDOWN)
            {
                PageManager pageControl = this.SelectionService.PrimarySelection as PageManager;

                if (pageControl != null)
                {
                    int xPos = (short)((uint)msg.LParam & 0x0000FFFFU);
                    int yPos = (short)(((uint)msg.LParam & 0xFFFF0000U) >> 16);

                    pageControl.CheckForMouseClick(new Point(xPos, yPos));
                }
            }

            base.WndProc(ref msg);
        }
    }
}
