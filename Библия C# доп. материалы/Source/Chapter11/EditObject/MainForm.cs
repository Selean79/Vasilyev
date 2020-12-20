using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonClass;

namespace ChildForm
{
    public partial class MainForm : Form
    {
        List<Person> persons = new List<Person>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            Person person = new Person("", "");
            EditPersonForm editForm = new EditPersonForm(person);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            persons.Add(person);
            personsListView.VirtualListSize = persons.Count;
            personsListView.Invalidate();
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;

            Person person = persons[personsListView.SelectedIndices[0]];
            
            EditPersonForm editForm = new EditPersonForm(person);
            if (editForm.ShowDialog() == DialogResult.OK)
                personsListView.Invalidate();
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < persons.Count)
            {
                e.Item = new ListViewItem(persons[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(persons[e.ItemIndex].LastName);
                e.Item.SubItems.Add(persons[e.ItemIndex].Age.ToString());
            }
        }

        private void personsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
