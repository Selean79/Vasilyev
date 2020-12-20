using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DPhotoWorkshop.Dialogs
{
    /// <summary>
    /// Interaction logic for InputStringValueWindow.xaml
    /// </summary>
    public partial class InputStringValueWindow : Window
    {
        public InputStringValueWindow(Window owner, string title, string prompt)
        {
            InitializeComponent();

            Owner = owner;
            Title = title;
            PromptString = prompt;
        }

        public string PromptString
        {
            get { return PromptLabel.Content.ToString(); }
            set { PromptLabel.Content = value; }
        }

        public string StringValue
        {
            get { return ValueTextBox.Text; }
            set { ValueTextBox.Text = value; }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
