using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataRelationProject
{
    public partial class Form1 : Form
    {
        DataSet dataset;
        
        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        void ReadData()
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = new OleDbCommand("SELECT * FROM Peoples; SELECT * FROM Address;");
            command.Connection = connection;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            dataset = new DataSet();
            adapter.Fill(dataset);
            connection.Close();

            if (dataset.Tables.Count == 0)
            {
                MessageBox.Show("Ошибка, результат не содежит строк");
                return;
            }

            DataRelation relation = new DataRelation("People_Address",
                dataset.Tables[0].Columns[0],
                dataset.Tables[1].Columns[1]);
            dataset.Relations.Add(relation);

            peopleDataGridView.DataSource = dataset.Tables[0];
            addressDataGridView.DataSource = dataset.Tables[1];
        }

        OleDbConnection CreateConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=Flenov;Initial Catalog=TestDatabase;Data Source=FLENOV-HP\SQLEXPRESS";
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }

            return connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow childRow in dataset.Tables[0].Rows[peopleDataGridView.CurrentRow.Index].GetChildRows("People_Address"))
                MessageBox.Show(childRow.ItemArray[2].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = addressDataGridView.CurrentRow.Index;
            DataRow row = dataset.Tables[1].Rows[index].GetParentRow("People_Address");
            MessageBox.Show(row.ItemArray[1].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UniqueConstraint unique = (UniqueConstraint)dataset.Tables[0].Constraints[0];
            MessageBox.Show("Колонка главной таблицы: " + unique.Columns[0].Caption);

            ForeignKeyConstraint foregnkey = (ForeignKeyConstraint)dataset.Tables[1].Constraints[0];
            MessageBox.Show("Колонка подчененной таблицы: " + foregnkey.Columns[0].Caption);
        }
    }
}
