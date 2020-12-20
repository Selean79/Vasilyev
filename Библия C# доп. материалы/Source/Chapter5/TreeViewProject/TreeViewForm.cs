using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeViewProject
{
    public partial class TreeViewForm : Form
    {
        public TreeViewForm()
        {
            InitializeComponent();
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add("Дочерний элемент");
            }
        }

        private void addRootButton_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode();
            newNode.Text = "Корневой элемент";
            treeView1.Nodes.Add(newNode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Remove();
        }

        private void viewTreeButton_Click(object sender, EventArgs e)
        {

            ViewCollection("", treeView1.Nodes);
        }

        void ViewCollection(string caption, TreeNodeCollection collection)
        {
            if (caption != "")
                caption += "-";

            foreach (TreeNode node in collection)
            {
                if (node.Nodes.Count > 0)
                    ViewCollection(caption + node.Text, node.Nodes);
                else
                    MessageBox.Show(caption + node.Text);
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Вы закрыли ветку: "+e.Node.Text);
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Вы открыли ветку: " + e.Node.Text);
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }
    }
}
