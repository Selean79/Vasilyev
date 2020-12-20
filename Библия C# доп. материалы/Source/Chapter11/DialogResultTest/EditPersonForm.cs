using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChildForm
{
    public partial class EditPersonForm : Form
    {
        public EditPersonForm()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
