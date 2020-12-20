using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MemoryStreamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string STRING_EXAMPLE = "Эту строку поместим в память";

            UnicodeEncoding unicode = new UnicodeEncoding();
            byte[] str = unicode.GetBytes(STRING_EXAMPLE);
            int string_size = unicode.GetByteCount(STRING_EXAMPLE);

            MemoryStream ms = new MemoryStream(string_size);
            ms.Write(str, 0, string_size);
            ms.Seek(0, SeekOrigin.Begin);

            byte[] buffer = new byte[string_size];
            ms.Read(buffer, 0, string_size);
            Text = unicode.GetString(buffer);
        }
    }
}
