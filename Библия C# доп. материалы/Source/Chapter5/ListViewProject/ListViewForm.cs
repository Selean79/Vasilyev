using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewProject
{
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem("Test");
            newItem.Group = listView1.Groups[0];
            listView1.Items.Add(newItem);
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            ListViewGroup newGroup = new ListViewGroup("Группа");
            listView1.Groups.Add(newGroup);

            ListViewItem newItem = new ListViewItem("Test", newGroup);
            listView1.Items.Add(newItem);
        }

        private void selectedButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                MessageBox.Show(item.Text);
        }

        private void deleteFirstButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.Items[0]);
            // listView1.Items.RemoveAt(0);
        }
    }
}
