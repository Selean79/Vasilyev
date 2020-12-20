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
    /// Interaction logic for NewProjectWindow.xaml
    /// </summary>
    public partial class NewProjectWindow : Window
    {
        public NewProjectWindow()
        {
            InitializeComponent();
        }

        public int BitmapWidth
        {
            get { return Convert.ToInt32(widthTextBox.Text); }
        }

        public int BitmapHeight
        {
            get { return Convert.ToInt32(heightTextBox.Text); }
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
