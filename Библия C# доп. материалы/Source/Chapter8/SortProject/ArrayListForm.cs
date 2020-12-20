﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonClass;

namespace ArrayListProject
{
    public partial class ArrayListForm : Form
    {
        Person person = new Person("Сергей", "Иванов");

        public ArrayListForm()
        {
            InitializeComponent();

            person.AddChild("Сергей", "Иванов");
            childrenListBox.Items.Add("Сергей");

            person.AddChild("Алексей", "Иванов");
            childrenListBox.Items.Add("Алексей");

            person.AddChild("Валя", "Иванов");
            childrenListBox.Items.Add("Валя");

            person.SortChildren();
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            person.AddChild(childFirstNameTextBox.Text, childLastNameTextBox.Text);

            childrenListBox.Items.Add(childFirstNameTextBox.Text);
        }

        private void deleteChildButton_Click(object sender, EventArgs e)
        {
            if (childrenListBox.SelectedIndex >= 0)
            {
                person.DeleteChild(childrenListBox.SelectedIndex);
                childrenListBox.Items.Remove(childrenListBox.SelectedItem);
            }
        }

        private void currentChildButton_Click(object sender, EventArgs e)
        {
            if (childrenListBox.SelectedIndex >= 0)
            {
                Person child = person.GetChild(childrenListBox.SelectedIndex);
                MessageBox.Show(child.FirstName);
            }
        }

        private void childrenButton_Click(object sender, EventArgs e)
        {
            foreach (Person children in person)
                MessageBox.Show(children.FirstName);
        }
    }
}
