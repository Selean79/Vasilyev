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
        OleDbConnection connection = new OleDbConnection();
        public DBProjectForm()
        {
            InitializeComponent();
        }

        private void соединитьсяСБазойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=Flenov;Initial Catalog=TestDatabase;Data Source=FLENOV-HP\SQLEXPRESS";
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        }

        private void количествоЗаписейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Peoples";
            int number = (int)command.ExecuteScalar();
            MessageBox.Show(number.ToString());
        }

        private void DBProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
