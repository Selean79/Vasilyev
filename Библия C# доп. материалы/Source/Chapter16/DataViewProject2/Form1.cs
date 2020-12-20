using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataViewProject
{
    public partial class Form1 : Form
    {
        DataView view;

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

            Object[] newRow = { 100, "Матвеева", "Матрена" };
            dataset.Tables[0].LoadDataRow(newRow, false);

            view = new DataView(dataset.Tables[0], "", "",
                DataViewRowState.Added);
            dataGridView1.DataSource = view;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                view.RowStateFilter = DataViewRowState.Added;
            else
                view.RowStateFilter = DataViewRowState.OriginalRows;
        }
    }
}
