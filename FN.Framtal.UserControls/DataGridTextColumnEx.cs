using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace FN.Framtal.UserControls
{
    public class DataGridTextColumnEx : DataGridTextColumn
    {
        public string Index
        {
            get { return (string)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Index.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IndexProperty =
            DependencyProperty.Register("Index", typeof(string), typeof(DataGridTextColumnEx), new PropertyMetadata(string.Empty));
    }
}
