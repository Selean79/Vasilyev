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
            
            DataColumn c = table.Columns.Add("Ключ", typeof(String));
            c.AutoIncrement = true;
            c.AutoIncrementSeed = 10;
            c.AutoIncrementStep = 5;
                        
            table.Columns.Add("Товар", typeof(String));
            table.Columns.Add("Количество", typeof(Int32));
            table.Columns.Add("Цена", typeof(Int32));
            table.Columns.Add("Сумма", typeof(String), "Количество * Цена");
            table.Columns.Add("Налоги", typeof(String), "Количество * Цена * 0.18");

            table.PrimaryKey = new DataColumn[] { table.Columns[0] };

            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
        }

        private void getFirstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(table.Rows[0].ItemArray[0].ToString());
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();
            row[1] = "Молоко";
            row["Количество"] = 10;
            row["Цена"] = 16;
            table.Rows.Add(row);
        }

        private void addRow2Button_Click(object sender, EventArgs e)
        {
            Object[] newRow = { 1, "Сахар", 2, 23};
            table.LoadDataRow(newRow, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow foundedRow = table.Rows.Find(20);
            MessageBox.Show(foundedRow.ItemArray[1].ToString());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
                return;

            DataRow row = table.Rows[0];
            row[1] = "Сахар";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
                return;
            table.Rows[0].Delete();
        }
    }
}
