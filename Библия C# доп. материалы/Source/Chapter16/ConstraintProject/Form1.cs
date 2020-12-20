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

            UniqueConstraint uc = 
                new UniqueConstraint(table.Columns[1]);
            table.Constraints.Add(uc);

            table.PrimaryKey = new DataColumn[] { table.Columns[0] };

            foreach (Constraint ct in table.Constraints)
                if (ct is UniqueConstraint)
                    MessageBox.Show(((UniqueConstraint)ct).Columns[0].Caption);
                       

            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
        }

        private void getFirstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(table.Rows[0].ItemArray[0].ToString());
        }
    }
}
