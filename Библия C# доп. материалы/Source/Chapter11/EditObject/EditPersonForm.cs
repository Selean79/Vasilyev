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
    public partial class EditPersonForm : Form
    {
        Person person;

        public EditPersonForm(Person person)
        {
            InitializeComponent();

            this.person = person;
            firstNameTextBox.Text = person.FirstName;
            lastNameTextBox.Text = person.LastName;
            ageNumericUpDown.Value = person.Age;
        }

        public Person EditedPerson
        {
            get { return person; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            person.FirstName = firstNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;
            person.Age = (int)ageNumericUpDown.Value;
        }
    }
}
