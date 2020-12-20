using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataSetProject
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();

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
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            connection.Close();

            dataset.Tables[0].Columns.Add("ФИО", typeof(String), "Фамилия + ' ' + Имя");

            if (dataset.Tables.Count == 0)
            {
                MessageBox.Show("Ошибка, результат не содежит строк");
                return;
            }
            dataGridView1.AutoGenerateColumns = true;
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
    }
}
