using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumIndex
{
    public partial class Form1 : Form
    {
        public enum MyColors
        {
            Red = 100,
            Green = 200,
            Blue = 300
        };

        public Form1()
        {
            InitializeComponent();

            foreach (string str in Enum.GetNames(typeof(MyColors)))
                myColorsComboBox.Items.Add(str);

            foreach (int i in Enum.GetValues(typeof(MyColors)))
                indexesСomboBox.Items.Add(i);
        }

        private void myColorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentColor = myColorsComboBox.SelectedItem.ToString();
            MyColors myColor = (MyColors)Enum.Parse(typeof(MyColors), currentColor);
            selectedValuesLabel.Text = myColor.ToString();
        }
    }
}
