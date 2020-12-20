using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataTableProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table;
        private BindingSource bindingSource = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Товар", typeof(String));
            table.Columns.Add("Количество", typeof(Int32));
            table.Columns.Add("Цена", typeof(Int32));

            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
        }

        private void getFirstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(table.Rows[0].ItemArray[0].ToString());
        }
    }
}
