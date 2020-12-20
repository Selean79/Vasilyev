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

        public WebRequest GetPage(string url)
        {
            HttpWebRequest request;
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(url);
            }
            catch (Exception)
            {
                MessageBox.Show("Не могу загрузить файл");
                return null;
            }


            if (useProxyCheckBox.Checked)
            {
                try
                {
                    WebProxy proxy = new WebProxy(proxyAddressTextBox.Text, Int32.Parse(proxyPortTextBox.Text));
                    proxy.Credentials = new NetworkCredential(proxyUsernameTextBox.Text, proxyPasswordTextBox.Text);
                    request.Proxy = proxy;
                }
                catch (Exception)
                {
                    MessageBox.Show("Не могу установить параметры прокси");
                }
            }

            return request;
        }

        private void useProxyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            proxyPanel.Enabled = useProxyCheckBox.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebRequest request = GetPage(urlTextBox.Text);
            if (request == null)
                return;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder pagebuilder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
                pagebuilder.AppendLine(line);

            response.Close();
            reader.Close();
            pageRichTextBox.Text = pagebuilder.ToString();
        }
    }
}
