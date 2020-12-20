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

            view = new DataView(dataset.Tables[0]);
            dataGridView1.DataSource = view;

            DataRowView row = view.AddNew();
            row[1] = "Простоквашин";
            row[2] = "Шарик";
            row.EndEdit();

            view.Sort = "idKey";
            DataRowView[] editrows = view.FindRows(3);
            foreach (DataRowView editrow in editrows)
                editrow[1] = "Отредактирован";

            view.Sort = "Фамилия";
            editrows = view.FindRows("Алексеев");
            foreach (DataRowView editrow in editrows)
                editrow[1] = "Бывший Алексеев";
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
        }
    }
}
