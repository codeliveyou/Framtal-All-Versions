using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace FN.Framtal.UserControls.Converter
{
    internal class StringNullOrEmptyToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool flag = value == null;
            if (!flag)
            {
                flag = string.IsNullOrEmpty(value.ToString().Trim());
            }
            return flag?Visibility.Collapsed:Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
