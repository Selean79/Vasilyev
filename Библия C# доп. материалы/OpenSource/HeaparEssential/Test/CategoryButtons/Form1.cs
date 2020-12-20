using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CategoryButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonsPanel1.SelectedButton!=null)
                MessageBox.Show(buttonsPanel1.SelectedButton.Title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (categoryBattons1.SelectedPanel != null)
                MessageBox.Show(categoryBattons1.SelectedPanel.SelectedButton.Title);
        }

        private void buttonsPanel1_Clicked(object value, int index)
        {
            MessageBox.Show("Selected button index: "+index.ToString());
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            buttonsPanel1.ShowCaptionPanel = checkBox1.Checked;
        }
    }
}
