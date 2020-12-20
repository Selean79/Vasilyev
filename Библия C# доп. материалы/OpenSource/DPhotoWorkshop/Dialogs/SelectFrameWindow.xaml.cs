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
using DPhotoWorkshop.Engine.Borders;

namespace DPhotoWorkshop.Dialogs
{
    class DecorFrame
    {
        public DecorFrame(BitmapSource img, Panel decor)
        {
            this.img = img;
            this.decor = decor;
        }

        public BitmapSource img { get; set; }
        public Panel decor { get; set; }
        public double leftoffset { get { return (200 - img.Width) / 2; } }
        public double topoffset { get { return (150 - img.Height) / 2; } }
    }

    /// <summary>
    /// Interaction logic for SelectFrameDialog.xaml
    /// </summary>
    public partial class SelectFrameDialog : Window
    {
        const int CELL_WIDTH = 200;
        const int CELL_HEIGHT = 150;

        BasePhotoFrame[] framesList = { new CircleFrame(), new PalaroidPhotoFrame() };

        public SelectFrameDialog(BitmapSource image)
        {
            InitializeComponent();

            Image = image;
            LoadPhotoFrames();
        }

        public BitmapSource Image
        {
            get;
            set;
        }

        public BasePhotoFrame SelectedFrame
        {
            get
            {
                if (framesGrid.SelectedIndex == -1)
                    return null;
                return framesList[framesGrid.SelectedIndex];
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        void LoadPhotoFrames()
        {
            List<DecorFrame> frames = new List<DecorFrame>();
            for (int i = 0; i < framesList.Length; i++)
            {
                Canvas panel = new Canvas();
                framesList[i].Visualize(panel, Image.Width, Image.Height);
                frames.Add(new DecorFrame(Image, panel));
            }
            framesGrid.ItemsSource = frames;
        }
    }
}
