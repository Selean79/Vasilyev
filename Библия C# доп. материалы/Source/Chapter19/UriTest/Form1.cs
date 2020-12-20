using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UriTest
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
            Uri uri = new Uri(urlTextBox.Text);

            List<string> lines = new List<string>();
            lines.Add("AbsolutePath: " + uri.AbsolutePath);
            lines.Add("AbsoluteUri: " + uri.AbsoluteUri);
            lines.Add("Authority: " + uri.Authority);
            lines.Add("DnsSafeHost: " + uri.DnsSafeHost);
            lines.Add("Host: " + uri.Host);
            lines.Add("HostNameType: " + uri.HostNameType.ToString());
            lines.Add("IsAbsoluteUri: " + uri.IsAbsoluteUri.ToString());
            lines.Add("IsDefaultPort: " + uri.IsDefaultPort.ToString());
            lines.Add("IsFile: " + uri.IsFile.ToString());
            lines.Add("IsLoopback: " + uri.IsLoopback.ToString());
            lines.Add("IsUnc: " + uri.IsUnc.ToString());
            lines.Add("LocalPath: " + uri.LocalPath);
            lines.Add("OriginalString: " + uri.OriginalString);
            lines.Add("PathAndQuery: " + uri.PathAndQuery);
            lines.Add("Port: " + uri.Port);
            lines.Add("Query: " + uri.Query);
            lines.Add("Scheme: " + uri.Scheme);
            lines.Add("UserInfo: " + uri.UserInfo);

            foreach (string segment in uri.Segments)
                lines.Add("Segment: " + segment);

            string query = uri.Query.Substring(1, uri.Query.Length - 1);
            string[] parameters = query.Split('&');

            foreach (string segment in parameters)
            {
                string[] paramvalues = segment.Split('=');
                lines.Add("Param: " + paramvalues[0]);
                if (paramvalues.Length > 1)
                    lines.Add("Value: " + paramvalues[1]);
            }

            richTextBox1.Lines = lines.ToArray();
        }
    }
}
