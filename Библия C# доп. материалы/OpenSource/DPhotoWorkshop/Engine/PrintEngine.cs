using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Printing;
using System.Windows.Media;
using System.Windows;
using DPhotoWorkshop.Dialogs;

namespace DPhotoWorkshop.Engine
{
    class PrintEngine
    {
        #region init

        PrintDialog printDialog = new PrintDialog();

        public PrintEngine(Canvas printingControl)
        {
            FillPage = true;
            MarginTop = 5;
            MarginBottom = 5;
            MarginLeft = 5;
            MarginRight = 5;

            this.printingControl = printingControl;
        }

        #endregion

        #region properties

        Canvas printingControl;
        public Canvas PrintingControl
        {
            get { return printingControl; }
            set { printingControl = value; }
        }

        public bool FillPage { get; set; }
        public int MarginTop { get; set; }
        public int MarginBottom { get; set; }
        public int MarginLeft { get; set; }
        public int MarginRight { get; set; }

        #endregion

        #region public methods

        public void PrintDocument(string printingName)
        {
            Viewbox parent = (Viewbox)printingControl.Parent;
            try
            {
                bool? result = printDialog.ShowDialog();
                if (result == null | result == false)
                    return;

                parent.Child = null;
                Size pageSize = new Size(printDialog.PrintableAreaWidth - (MarginLeft + MarginRight), printDialog.PrintableAreaHeight - (MarginTop + MarginBottom));

                double scale = Math.Min(pageSize.Width / printingControl.Width, pageSize.Height / printingControl.Height);
                Border printBox = new Border();
                printBox.Child = printingControl;
                printBox.Width = printingControl.Width * scale;
                printBox.Height = printingControl.Height * scale;

                printingControl.LayoutTransform = new ScaleTransform(scale, scale);
                printingControl.Measure(pageSize);
                printingControl.Arrange(new Rect(MarginLeft, MarginTop, pageSize.Width, pageSize.Height));

                printDialog.PrintVisual(printingControl, "DPhotoWorkshop - " + printingName);
                printBox.Child = null;

            }
            catch (Exception e)
            {
                MessageBox.Show("Can't print document. " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                printingControl.LayoutTransform = null;
                parent.Child = printingControl;
            }
        }

        public void ShowPrintPropertiesDialog()
        {
            PrintPropertiesWindow printProperties = new PrintPropertiesWindow();
            printProperties.FillPage = FillPage;

            bool? result = printProperties.ShowDialog();
            if (result != null & result == true)
            {
                FillPage = printProperties.FillPage;
            }
        }

        #endregion 
    }
}
