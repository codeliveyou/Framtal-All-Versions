using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for TitleBoxWithPrefix.xaml
    /// </summary>
    public partial class TitleBoxWithPrefix : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(TitleBoxWithPrefix), new PropertyMetadata(OnTextPropertyChanged));

        public static readonly DependencyProperty PrefixProperty = DependencyProperty.Register(nameof(Prefix), typeof(string), typeof(TitleBoxWithPrefix), new PropertyMetadata(OnPrefixPropertyChanged));

        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as TitleBoxWithPrefix).tbText.Text = e.NewValue as string;
        }

        public string Prefix
        {
            get => GetValue(PrefixProperty) as string;
            set => SetValue(PrefixProperty, value);
        }

        private static void OnPrefixPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as TitleBoxWithPrefix).tbPrefix.Text = e.NewValue as string;
        }

        public TitleBoxWithPrefix()
        {
            InitializeComponent();
        }
    }
}
