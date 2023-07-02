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
    /// Interaction logic for IntegerControlWithPrefix.xaml
    /// </summary>
    public partial class IntegerControlWithPrefix : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(IntegerControlWithPrefix), new PropertyMetadata(OnTitlePropertyChanged));

        public string Title
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }

        private static void OnTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as IntegerControlWithPrefix;
            var newValue = e.NewValue as string;
            control.tbTitle.Text = newValue;
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(nameof(Value), typeof(string), typeof(IntegerControlWithPrefix), new PropertyMetadata(OnValuePropertyChanged));

        public string Value
        {
            get => GetValue(ValueProperty) as string;
            set => SetValue(ValueProperty, value);
        }

        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as IntegerControlWithPrefix;
            var newValue = e.NewValue as string;
            control.icValue.Value = newValue;
        }

        public IntegerControlWithPrefix()
        {
            InitializeComponent();
        }
    }
}
