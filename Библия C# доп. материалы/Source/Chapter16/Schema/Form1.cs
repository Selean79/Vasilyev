using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Schema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        void ReadData()
        {
            OleDbConnection connection = CreateConnection();

            Object[] dbrestrinct = { "TestDatabase", null, null, null };
            DataTable table = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, dbrestrinct);

            foreach (DataRow row in table.Rows)
                tablesListBox.Items.Add(row["TABLE_NAME"]);

            Object[] clmnrestrinct = { "TestDatabase", null, "Peoples", null };
            DataTable columns = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, clmnrestrinct);

            foreach (DataRow row in columns.Rows)
                columnsListBox.Items.Add(row["COLUMN_NAME"]);
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
