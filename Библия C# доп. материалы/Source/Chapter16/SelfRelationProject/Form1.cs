using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SelfRelationProject
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

            OleDbCommand command = new OleDbCommand("SELECT * FROM Positions ORDER BY idMainPosition");
            command.Connection = connection;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            dataset = new DataSet();
            adapter.Fill(dataset);
            connection.Close();

            DataRelation relation = new DataRelation("Position",
                dataset.Tables[0].Columns[0],
                dataset.Tables[0].Columns[1]);
            dataset.Relations.Add(relation);

            foreach (DataRow row in dataset.Tables[0].Rows)
                if (row.IsNull(1))
                    AddTreenode(row, null);
                else
                    break;

            dataset.Tables[0].Columns.Add("Кол-во подчиненных", typeof(int), "Count(Child.idPosition)");
            dataGridView1.DataSource = dataset.Tables[0];

            foreach (Constraint c in dataset.Tables[0].Constraints)
                if (c is ForeignKeyConstraint)
                {
                    ((ForeignKeyConstraint)c).DeleteRule = Rule.None;
                    ((ForeignKeyConstraint)c).UpdateRule = Rule.None;
                }
        }

        void AddTreenode(DataRow row, TreeNode node)
        {
            TreeNode currnode;
            if (node == null)
                currnode = treeView1.Nodes.Add(row.ItemArray[2].ToString());
            else
                currnode = node.Nodes.Add(row.ItemArray[2].ToString());

            foreach (DataRow currrow in row.GetChildRows("Position"))
                AddTreenode(currrow, currnode);
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
