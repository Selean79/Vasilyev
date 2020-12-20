using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckedListBoxProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (String str in checkedListBox1.CheckedItems)
                MessageBox.Show(str);
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.CheckedIndices.Count - 1 ; i >= 0;  i--)
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[i]);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Это что-то", true);
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
                selectedLabel.Text = checkedListBox1.SelectedItem.ToString();
        }
    }
}
