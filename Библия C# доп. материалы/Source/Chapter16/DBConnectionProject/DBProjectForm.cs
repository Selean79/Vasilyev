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
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Temp\database.mdb;Persist Security Info=False";
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        }
    }
}
