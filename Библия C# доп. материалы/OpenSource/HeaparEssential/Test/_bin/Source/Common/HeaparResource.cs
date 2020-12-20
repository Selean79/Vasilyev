using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace heaparessential.Common
{
    public class HeaparResource
    {
        public static ImageList LoadBitmapStrip(Type assemblyType, string imageName, 
            Size imageSize, Point transparentPixel)
        {
            return LoadBitmapStrip(assemblyType, imageName, imageSize, true, transparentPixel);
        }

        protected static ImageList LoadBitmapStrip(Type assemblyType, string imageName, 
            Size imageSize, bool makeTransparent, Point transparentPixel)
        {
            ImageList images = new ImageList();
            images.ImageSize = imageSize;
            Assembly myAssembly = Assembly.GetAssembly(assemblyType);
            Stream imageStream = myAssembly.GetManifestResourceStream(imageName);
            Bitmap pictures = new Bitmap(imageStream);

            if (makeTransparent)
            {
                Color backColor = pictures.GetPixel(transparentPixel.X, transparentPixel.Y);
                pictures.MakeTransparent(backColor);
            }
			    
            images.Images.AddStrip(pictures);

            return images;
        }

        public static Bitmap LoadBitmap(Type assemblyType, string imageName)
        {
            Assembly myAssembly = Assembly.GetAssembly(assemblyType);
            Stream imageStream = myAssembly.GetManifestResourceStream(imageName);
            Bitmap pics = new Bitmap(imageStream);

            return pics;
        }
    }
}