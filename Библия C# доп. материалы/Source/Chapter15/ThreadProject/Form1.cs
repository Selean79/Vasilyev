using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadProject
{
    public partial class Form1 : Form
    {
        delegate void PrintInRhichTextBox(string str);
        private PrintInRhichTextBox PrintDelegateFunc;

        public Form1()
        {
            InitializeComponent();
            PrintDelegateFunc = new PrintInRhichTextBox(PrintFunc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ThreadFunction));
            thread.Start();
        }

        void PrintFunc(string str)
        {
            richTextBox1.AppendText(str);
        }

        void ThreadFunction()
        {
            for (int i = 0; i < 10; i++)
                richTextBox1.Invoke(PrintDelegateFunc, new object[] { i.ToString() });
        }
    }
}
