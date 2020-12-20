using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpecifiedResult
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActionRequestForm form = new ActionRequestForm();
            form.ShowDialog();
            MessageBox.Show(form.Result.ToString());
        }
    }
}
