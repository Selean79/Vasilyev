using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonClass;

namespace InterfaceProject
{
    public partial class Form1 : Form
    {
        Person person = new Person("Михиал", "Фленов");
        Object personObject;
        IPurse purse;

        public Form1()
        {
            InitializeComponent();
            
            personObject = person;
            purse = person;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (personObject is IPurse)
            {
                ((IPurse)personObject).AddMoney((int)numericUpDown1.Value);                
                sumLabel.Text = ((IPurse)personObject).Sum.ToString();
            }
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            DecMoney(person);
        }

        void DecMoney(IPurse purse)
        {
            purse.DecMoney((int)numericUpDown1.Value);
            sumLabel.Text = purse.Sum.ToString();
        }
    }
}
