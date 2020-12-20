using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpecifiedResult
{
    public partial class ActionRequestForm : Form
    {
        public enum FileAction { Overwrite, Rename, Skip, OverwriteOlder, 
            OverwriteAll, SkipAll, Cancel }

        public FileAction Result { get; set; }

        public ActionRequestForm()
        {            
            InitializeComponent();

            Result = FileAction.Cancel;
        }

        private void overwriteButton_Click(object sender, EventArgs e)
        {
            Result = FileAction.Overwrite;
            Close();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            Result = FileAction.Rename;
            Close();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            Result = FileAction.Skip;
            Close();
        }

        private void overwriteAllButton_Click(object sender, EventArgs e)
        {
            Result = FileAction.OverwriteAll;
            Close();
        }

        private void skipAllButton_Click(object sender, EventArgs e)
        {
            Result = FileAction.SkipAll;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Result = FileAction.Cancel;
            Close();
        }
    }
}
