using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace DPhotoWorkshop.Engine
{
    public class ResizeButtonSizeConverter : IValueConverter
    {
        public static int BUTTON_SIZE = 3;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return BUTTON_SIZE;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
