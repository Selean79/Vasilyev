using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FindRecordProject
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

            OleDbCommand command = new OleDbCommand("SELECT * FROM Peoples");
            command.Connection = connection;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            dataset = new DataSet();
            adapter.Fill(dataset);
            connection.Close();

            dataset.Tables[0].PrimaryKey = new DataColumn[] { dataset.Tables[0].Columns[0] };
            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSource;
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

        private void findButton_Click(object sender, EventArgs e)
        {
            DataRow[] rows = dataset.Tables[0].Select("[Фамилия] LIKE '" + nameTextBox.Text + "%'", "Имя DESC");
            //DataRow[] rows = dataset.Tables[0].Select("[ДатаРождения] = #12/21/1974#");

            string found = "";
            foreach (DataRow row in rows)
            {
                found += row.ItemArray[1].ToString() + " " + row.ItemArray[2].ToString() + "\n";
            }
            MessageBox.Show(found);
        }
    }
}
