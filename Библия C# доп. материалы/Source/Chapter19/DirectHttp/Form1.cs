using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DirectHttp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            HttpClient client = new HttpClient();
            client.GetPageStatus(new Uri(urlTextBox.Text));
            
            if (client.PageContent != null)
                richTextBox1.Text = client.PageContent.ToString();
        }
    }
}
