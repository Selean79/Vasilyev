using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;

namespace DataSetProject
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
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Peoples p , Address a WHERE idKey = idPeopleKey", connection);

            adapter.Fill(dataset);

            connection.Close();

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Peoples p , Address a WHERE idKey = idPeopleKey", connection);

            adapter.UpdateCommand = new OleDbCommand(
                "UPDATE Peoples SET Фамилия = ?, Имя = ?, Пол = ? " +
                "WHERE idKey = ?;" +
                "UPDATE Address SET Адрес = ? " +
                "WHERE idAddressKey = ?"
                );

            adapter.UpdateCommand.Parameters.Add("Фамилия", OleDbType.VarChar, 50, "Фамилия");
            adapter.UpdateCommand.Parameters.Add("Имя", OleDbType.VarChar, 50, "Имя");
            adapter.UpdateCommand.Parameters.Add("Пол", OleDbType.VarChar, 50, "Пол");
            adapter.UpdateCommand.Parameters.Add("idKey", OleDbType.Integer, 10, "idKey");
            adapter.UpdateCommand.Parameters.Add("Адрес", OleDbType.VarChar, 50, "Адрес");
            adapter.UpdateCommand.Parameters.Add("idAddressKey", OleDbType.Integer, 10, "idAddressKey");

            adapter.UpdateCommand.Connection = connection;

            adapter.Update(dataset.Tables[0]);
        }
    }
}
