using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace HttpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void useProxyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request;
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(urlTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Не могу загрузить файл");
                return;
            }

            StringBuilder pagebuilder = new StringBuilder();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string line;
            while ((line = reader.ReadLine()) != null)
                pagebuilder.AppendLine(line);

            response.Close();
            reader.Close();
            pageRichTextBox.Text = pagebuilder.ToString();
        }
    }
}
