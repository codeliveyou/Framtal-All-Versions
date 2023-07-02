using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls.Control
{
    public class HeaderedDataGrid : DataGrid
    {
        public static readonly DependencyProperty ChapterNumberProperty = DependencyProperty.Register(nameof(ChapterNumber), typeof(string), typeof(HeaderedDataGrid));
        public string ChapterNumber
        {
            get => GetValue(ChapterNumberProperty) as string;
            set => SetValue(ChapterNumberProperty, value);
        }
        public static readonly DependencyProperty TitleContentProperty = DependencyProperty.Register(nameof(TitleContent), typeof(object), typeof(HeaderedDataGrid));
        public object TitleContent
        {
            get => GetValue(TitleContentProperty) as object;
            set => SetValue(TitleContentProperty, value);
        }
        public static readonly DependencyProperty RowsTitleContentProperty = DependencyProperty.Register(nameof(RowsTitleContent), typeof(object), typeof(HeaderedDataGrid));
        public object RowsTitleContent
        {
            get => GetValue(RowsTitleContentProperty) as object;
            set => SetValue(RowsTitleContentProperty, value);
        }
    }
}
