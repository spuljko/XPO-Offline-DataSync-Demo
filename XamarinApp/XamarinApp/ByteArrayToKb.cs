﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinApp
{
    public class ByteArrayToKb : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return 0;
            else
            {
                Byte[] bytes = value as Byte[];
                if (bytes == null)
                    return 0;


              return FileSizeFormatter.FormatSize(bytes.LongLength);
            }
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
