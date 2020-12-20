using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using heaparessential.Controls;

namespace heaparessential.Controls
{
    public class PageSelectorTypeEditor : UITypeEditor
    {
        private IWindowsFormsEditorService wfes = null;

        /// <summary>
        /// Edit value
        /// </summary>
        /// <param name="context"></param>
        /// <param name="provider"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object EditValue(ITypeDescriptorContext context,
            IServiceProvider provider, object value)
        {
            wfes = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            ListBox lb = new ListBox();
            lb.BorderStyle = BorderStyle.None;

            PageManager comp = ((PageManager)(provider.GetType().GetProperty("Component").GetGetMethod().Invoke(provider, new object[0])));

            for (int i = 0; i < comp.Pages.Count; i++)
                lb.Items.Add(comp.Pages[i].Name);

            lb.SelectedValueChanged += new EventHandler(lb_SelectedValueChanged);

            wfes.DropDownControl(lb);
            return lb.Text;
        }

        /// <summary>
        /// Get edit style
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override UITypeEditorEditStyle GetEditStyle(
            ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        /// <summary>
        /// Item from listbox is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (wfes != null)
                wfes.CloseDropDown();
        }
    }
}