using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Interop;
using System.Windows;
using System.Windows.Input;
using DPhotoWorkshop.Engine.Borders;
using System.IO;
using DPhotoWorkshop.Engine;
using System.Xml;
using DPhotoWorkshop.Dialogs;

namespace DPhotoWorkshop.Engine
{
    class DPhotoEngine
    {
        public const string PROJECT_EXT = ".dphw";
        const int FILE_BUFFER_SIZE = 4096;

        #region init

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        public DPhotoEngine(Image imageControl, DesignerCanvas imageCanvas)
        {
            this.imageControl = imageControl;
            this.ImageCanvas = imageCanvas;
            DefaultInit();

            CompressionRate = 90;
        }

        #endregion

        #region properties

        System.Drawing.Bitmap systemBitmap;
        System.Drawing.Bitmap SystemBitmap
        {
            get { return systemBitmap; }
            set { systemBitmap = value; }
        }

        Image imageControl;
        public Image ImageControl
        {
            get { return imageControl; }
            set { imageControl = value; }
        }

        string filename;
        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }

        public bool IsPhotoWorkshopProject
        {
            get
            {
                if (Path.GetExtension(filename).ToLower() == PROJECT_EXT)
                    return true;
                else
                    return false;
            }
        }

        public string documentName
        {
            get
            {
                if (filename != "")
                    return filename;
                else
                    return "Untitled";
            }
        }

        BitmapSource bitmapImage = null;
        public BitmapSource BitmapImage
        {
            get { return bitmapImage; }
            set
            {
                bitmapImage = value;
                MakePreviewImage();
            }
        }

        BitmapSource previewImage = null;
        public BitmapSource PreviewImage
        {
            get { return previewImage; }
        }

        BasePhotoFrame photoFrame;
        public BasePhotoFrame PhotoFrame
        {
            get { return photoFrame; }
            set
            {
                photoFrame = value;
                ApplyPhotoFrame();
            }
        }

        DesignerCanvas imageCanvas;
        public DesignerCanvas ImageCanvas
        {
            get { return imageCanvas; }
            set
            {
                if (imageCanvas == null)
                    textEngine = new TextEngine(value);
                else
                    textEngine.Canvas = value;
                imageCanvas = value;
            }
        }

        TextEngine textEngine;
        public TextEngine TextEngine
        {
            get { return textEngine; }
        }

        bool modified = false;
        public bool Modified
        {
            get { return modified; }
            set { modified = value; }
        }

        public int CompressionRate { get; set; }

        #endregion

        #region private methods

        void ApplyPhotoFrame()
        {
            int i = 0;
            while (i < ImageCanvas.Children.Count)
            {
                UIElement element = ImageCanvas.Children[i];
                if (element is Panel)
                    if ((element as Panel).Name == "BorderFrame")
                    {
                        ImageCanvas.Children.Remove(element);
                        continue;
                    }
                i++;                
            }
        }

        void DefaultInit()
        {
            ClearProject();
            systemBitmap = new System.Drawing.Bitmap(400, 300);
            PrepareSystemBitmap();
        }

        void PrepareSystemBitmap()
        {
            BitmapImage = BitmapBitmapSource(systemBitmap);
            imageControl.Source = bitmapImage;
            imageControl.Width = bitmapImage.Width;
            imageControl.Height = bitmapImage.Height;
            ImageResized();
        }

        void MakePreviewImage()
        {
            int h = (int)(200 / bitmapImage.Width * bitmapImage.Height);
            int w = 200;
            if (h > 150)
            {
                h = 150;
                w = (int)(150 / bitmapImage.Height * bitmapImage.Width);
            }
            System.Drawing.Bitmap preview = new System.Drawing.Bitmap(w, h);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(preview);
            g.DrawImage(systemBitmap, new System.Drawing.Rectangle(0, 0, preview.Width, preview.Height));
            previewImage = BitmapBitmapSource(preview);
        }

        BitmapSource BitmapBitmapSource(System.Drawing.Bitmap source)
        {
            IntPtr hBitmap = source.GetHbitmap();
            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(hBitmap, IntPtr.Zero, Int32Rect.Empty,
                   BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(hBitmap);
            }

        }

        #endregion

        #region project methods

        public void ClearProject()
        {
            PhotoFrame = null;
            while (ImageCanvas.Children.Count > 1)
                ImageCanvas.Children.RemoveAt(1);
            filename = String.Empty;
            Modified = false;
        }

        public void CreateFile(int width, int height)
        {
            ClearProject();

            systemBitmap = new System.Drawing.Bitmap(width, height);
            BitmapImage = BitmapBitmapSource(systemBitmap);
            imageControl.Source = bitmapImage;
            imageControl.Width = bitmapImage.Width;
            imageControl.Height = bitmapImage.Height;
        }

        public void OpenFile(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show("Sorry, but file '" + filename + "' not found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            ClearProject();
            this.filename = filename;

            if (IsPhotoWorkshopProject)
                LoadProjectFile();
            else
                LoadImageFile();
        }

        public void ShowPropertiesDialog()
        {
            ProjectPropertiesWindow projProp = new ProjectPropertiesWindow();
            projProp.CompressionRate = CompressionRate;

            bool? result = projProp.ShowDialog();
            if (result != null & result == true)
            {
                CompressionRate = projProp.CompressionRate;
            }
        }

        #endregion

        #region loading saving

        void LoadImageFile()
        {
            ImageControl.Cursor = Cursors.Wait;

            try
            {
                systemBitmap = new System.Drawing.Bitmap(filename);
                PrepareSystemBitmap();
            }
            finally
            {
                ImageControl.Cursor = Cursors.Arrow;
            }
        }

        void LoadProjectFile()
        {
            FileStream fs;
            try
            {
                fs = new FileStream(filename, FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file not found. Sorry.");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Can't open file");
                return;
            }

            XmlTextReader xmlIn = new XmlTextReader(fs);
            xmlIn.WhitespaceHandling = WhitespaceHandling.None;
            xmlIn.MoveToContent();

            if (xmlIn.Name != "PhotoWorkshopProject")
                throw new ArgumentException("Incorrect file format.");
            string version = xmlIn.GetAttribute(0);

            int xIndex = 1;
            do
            {
                if (!xmlIn.Read())
                    throw new ArgumentException("An element was expected but could not be read in");


                if ((xmlIn.NodeType == XmlNodeType.EndElement) && (xmlIn.Name == "PhotoWorkshopProject"))
                    break;

                if (xmlIn.NodeType == XmlNodeType.EndElement)
                    continue;

                if (xmlIn.Name == "PhotoPicture")
                {
                    LoadPictureFromFile(xmlIn);
                    continue;
                }

                if (xmlIn.Name == "DesignerItem")
                {
                    DesignerBaseItem item = DesignerBaseItem.CreateDesignerItemByID(Convert.ToInt32(xmlIn.GetAttribute("Kind")));
                    imageCanvas.Children.Add(item);
                    item.LoadFromFile(xmlIn);
                    Canvas.SetZIndex(item, xIndex);
                }
                if (xmlIn.Name == "BaseFrame")
                {
                    BasePhotoFrame frame = BasePhotoFrame.CreatePhotoFrameByID(Convert.ToInt32(xmlIn.GetAttribute("Kind")));
                    frame.LoadFromFile(xmlIn);
                    PhotoFrame = frame;
                }
                if (xmlIn.Name == "ProjectProperties")
                {
                    LoadProjectPropertiesFromFile(xmlIn);
                }

                xIndex++;
            } while (!xmlIn.EOF);

            xmlIn.Close();
            fs.Close();

            if (PhotoFrame != null)
                PhotoFrame.Visualize(ImageCanvas, imageControl.Width, imageControl.Height);
        }

        void LoadProjectPropertiesFromFile(XmlTextReader xmlIn)
        {
            CompressionRate = Convert.ToByte(xmlIn.GetAttribute("CompressionRate"));
        }

        void LoadPictureFromFile(XmlTextReader xmlIn)
        {
            xmlIn.MoveToContent();
            byte[] buffer = new byte[FILE_BUFFER_SIZE];
            int readByte = 0;
            
            MemoryStream memory = new MemoryStream(10000);
            BinaryWriter writer = new BinaryWriter(memory);
            
            do
            {
                readByte = xmlIn.ReadBase64(buffer, 0, FILE_BUFFER_SIZE);
                writer.Write(buffer, 0, readByte);
            } while (readByte >= FILE_BUFFER_SIZE);

            writer.Flush();

            systemBitmap = new System.Drawing.Bitmap(memory);
            PrepareSystemBitmap();
        }

        public void SaveProjectFile()
        {
            if (!IsPhotoWorkshopProject)
                new Exception("The file name is incorrect");

            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlTextWriter xmlOut = new XmlTextWriter(fs, Encoding.Unicode);

            xmlOut.Formatting = Formatting.Indented;

            xmlOut.WriteStartDocument();
            xmlOut.WriteComment("CyD Software Labs - DPhotoWorkshop (www.dphotoworkshop.com)");
            xmlOut.WriteComment("Be carifully to edit the file manually");

            xmlOut.WriteStartElement("PhotoWorkshopProject");
            xmlOut.WriteAttributeString("Version", "1");

            SavePictureToFile(xmlOut);
            SaveProjectPropertiesToFile(xmlOut);

            if (PhotoFrame != null)
                PhotoFrame.SaveToFile(xmlOut);

            foreach (Object item in imageCanvas.Children)
                if (item is DesignerBaseItem)
                    (item as DesignerBaseItem).SaveToFile(xmlOut);

            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();
            xmlOut.Close();
            fs.Close();

            Modified = false;
        }

        public void ExportProjectAsImage(string filename)
        {
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)imageCanvas.Width, (int)imageCanvas.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(imageCanvas);

            BitmapEncoder image = new BmpBitmapEncoder();
            switch (Path.GetExtension(filename).ToLower())
            {
                case ".png":
                    image = new PngBitmapEncoder();
                    break;
                case ".jpg":
                    image = new JpegBitmapEncoder();
                    ((JpegBitmapEncoder)image).QualityLevel = CompressionRate;
                    break;                    
            }
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream fs = File.Create(filename))
            {
                image.Save(fs);
            }
        }

        void SaveProjectPropertiesToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("ProjectProperties");
            xmlOut.WriteAttributeString("CompressionRate", CompressionRate.ToString());
            xmlOut.WriteEndElement();
        }

        void SavePictureToFile(XmlTextWriter xmlOut)
        {
            ImageControl.Cursor = Cursors.Wait;
            try
            {
                xmlOut.WriteStartElement("PhotoPicture");
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.QualityLevel = CompressionRate;
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                MemoryStream memory = new MemoryStream(1000000);
                encoder.Save(memory);
                memory.Seek(0, SeekOrigin.Begin);

                BinaryReader br = new BinaryReader(memory);
                int bufferSize = 1000;
                byte[] buffer = new byte[bufferSize];
                int readBytes = 0;
                do
                {
                    readBytes = br.Read(buffer, 0, bufferSize);
                    xmlOut.WriteBase64(buffer, 0, readBytes);
                } while (bufferSize <= readBytes);
                br.Close();
                xmlOut.WriteEndElement();
            }
            finally
            {
                ImageControl.Cursor = Cursors.Arrow;
            }
        }

        #endregion

        #region add objects

        public void InsertText(string text)
        {
            DesignerLabel label = new DesignerLabel();
            label.FontSize = TextEngine.GetSelectedFontSize();
            label.Text = text;
            label.FontFamily = TextEngine.GetSelectedFontFamiy();
            ImageCanvas.Children.Add(label);
            Canvas.SetLeft(label, 1);
            Canvas.SetTop(label, 1);
            Modified = true;
        }

        #endregion

        #region common public

        public void ImageResized()
        {
            ResizeButtonSizeConverter.BUTTON_SIZE = (int)ImageCanvas.Height / 80;
        }

        #endregion
    }
}
