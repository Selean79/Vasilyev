using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyOwnException
{
    public partial class Form1 : Form
    {
        CarEngine engine = new CarEngine("Мой двигатель V6");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                engine.StartEngine();
            }
            catch (EngineException ee)
            {
                MessageBox.Show("Двигатель '" + ee.Engine.Name + 
                    "'\nCгенерировал ошибку: '" + ee.Message + "'");
            }
        }
    }
}
