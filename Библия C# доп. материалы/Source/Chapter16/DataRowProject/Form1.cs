using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataRowProject
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        DataSet dataset = new DataSet();
        
        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        void ReadData()
        {
            OleDbConnection connection = CreateConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Peoples", connection);

            adapter.Fill(dataset);

            connection.Close();

            foreach (DataColumn column in dataset.Tables[0].Columns)
            {
                listView1.Columns.Add(column.Caption);
            }

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                ListViewItem item = listView1.Items.Add(row.ItemArray[0].ToString());
                for (int i = 1; i < row.ItemArray.Length; i++)
                    item.SubItems.Add(row.ItemArray[i].ToString());
            }
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
