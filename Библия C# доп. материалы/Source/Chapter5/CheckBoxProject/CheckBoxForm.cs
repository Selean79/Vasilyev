using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckBoxProject
{
    public partial class CheckBoxForm : Form
    {
        public CheckBoxForm()
        {
            InitializeComponent();
        }

        private void byDefaultButton_Click(object sender, EventArgs e)
        {
            runAtStartupCheckBox.CheckState = CheckState.Indeterminate;
            deleteOnExitCheckBox.Checked = false;
        }
    }
}
