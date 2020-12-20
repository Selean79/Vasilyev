using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBConnectionProject
{
    public partial class DBProjectForm : Form
    {
        public DBProjectForm()
        {
            InitializeComponent();

            ReadData();
        }

        void ReadData()
        {
            const int NAME_INDEX = 2;

            OleDbConnection connection = CreateConnection();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Peoples (Фамилия, Имя, ДатаРождения, Пол) " +
                " Values ('Сергеева', 'Валентина', '05.10.1971', 'Ж'); " +
                "SELECT * FROM Peoples WHERE Фамилия='Смирнов'; " +
                "SELECT * FROM Peoples WHERE Фамилия='Иванов'";

            OleDbDataReader reader = command.ExecuteReader();
            do
            {
                while (reader.Read())
                {
                    ListViewItem item = listView1.Items.Add(reader["Фамилия"].ToString().TrimEnd());
                    item.SubItems.Add(reader.GetValue(NAME_INDEX).ToString().TrimEnd());
                    item.SubItems.Add(reader.GetDateTime(3).ToLongDateString());
                    item.SubItems.Add(reader.GetValue(4).ToString());
                }
            } while (reader.NextResult());

            connection.Close();
        }

        private void количествоЗаписейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Peoples";

            int number = (int)command.ExecuteScalar();
            MessageBox.Show(number.ToString());

            connection.Close();
        }

        private void вставитьИОткатитьТранзакциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = CreateConnection();

            OleDbTransaction transaction = connection.BeginTransaction();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Peoples (Фамилия, Имя, ДатаРождения, Пол) " +
                " Values ('Иванова', 'Елена', '01.05.1971', 'Ж')";
            command.Transaction = transaction;

            int rows = command.ExecuteNonQuery();
            MessageBox.Show(rows.ToString());

            transaction.Rollback();

            connection.Close();
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
