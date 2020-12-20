using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIProject
{
    public partial class MDIMainForm : Form
    {
        public MDIMainForm()
        {
            InitializeComponent();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentForm child = new DocumentForm();
            child.MdiParent = this;
            child.Text = "Документ - " + MdiChildren.Length;
            child.Show();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void выровнятьГоризонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void выровнятьВертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void выровнятьИконкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void пометитьАктивноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Text = "Активное окно";
        }

        private void переименоватьЗаголовкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 1;
            foreach (Form f in MdiChildren)
            {
                f.Text = "Дочернее окно " + (index++).ToString();
            }                
        }
    }
}
