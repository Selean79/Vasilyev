using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProgramProperties();
        }

        private void LoadProgramProperties()
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Библия C#").CreateSubKey("Тестовые примеры");
            Width = (int)registryKeyOptions.GetValue("width", 600);
            Height = (int)registryKeyOptions.GetValue("height", 400);
            Left = (int)registryKeyOptions.GetValue("left", 50);
            Top = (int)registryKeyOptions.GetValue("top", 50);
            WindowState = (FormWindowState)registryKeyOptions.GetValue("WinState", FormWindowState.Normal);
        }

        /// <summary>
        /// Save Program Properties
        /// </summary>
        private void SaveProgramProperties()
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Библия C#").CreateSubKey("Примеры");
            registryKeyOptions.SetValue("WinState", (int)WindowState);
            if (WindowState == FormWindowState.Normal)
            {
                registryKeyOptions.SetValue("width", Width);
                registryKeyOptions.SetValue("height", Height);
                registryKeyOptions.SetValue("left", Left);
                registryKeyOptions.SetValue("top", Top);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProgramProperties();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Библия C#").CreateSubKey("Примеры");
            String[] names = registryKeyOptions.GetValueNames();
            textBox1.Lines = names;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Библия C#").CreateSubKey("Примеры");
            registryKeyOptions.DeleteValue("width");
        }
    }
}
