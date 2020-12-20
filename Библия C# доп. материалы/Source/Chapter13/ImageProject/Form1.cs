using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProject
{
    public partial class Form1 : Form
    {
        Image image;

        public Form1()
        {
            InitializeComponent();
        }

            private void loadImageButton_Click(object sender, EventArgs e)
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Image files|*.bmp;*.png;*.jpg";
                if (openDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    image = Image.FromFile(openDialog.FileName);
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Ошибка чтения картинки");
                    return;
                }


                panel1.AutoScroll = true;
                panel1.AutoScrollMinSize = new Size(image.Size.Width * 2, image.Size.Height * 2);
                panel1.Invalidate();
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (image == null)
                return;

            e.Graphics.DrawImage(image, panel1.AutoScrollPosition.X, panel1.AutoScrollPosition.Y, image.Size.Width * 2, image.Size.Height * 2);
        }
    }
}
