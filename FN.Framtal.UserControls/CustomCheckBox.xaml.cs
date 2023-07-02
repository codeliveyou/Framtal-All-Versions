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
    /// Interaction logic for CustomCheckBox.xaml
    /// </summary>
    public partial class CustomCheckBox : UserControl
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(nameof(Value), typeof(string), typeof(CustomCheckBox), new PropertyMetadata(OnValuePropertyChanged));

        public static readonly DependencyProperty CheckedProperty = DependencyProperty.Register(nameof(Checked), typeof(bool), typeof(CustomCheckBox), new PropertyMetadata(OnCheckedPropertyChanged));

        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register(nameof(Number), typeof(string), typeof(CustomCheckBox), new PropertyMetadata(OnNumberPropertyChanged));

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(CustomCheckBox), new PropertyMetadata(OnTitlePropertyChanged));

        public bool? Checked
        {
            get => GetValue(CheckedProperty) as bool?;
            set => SetValue(CheckedProperty, value);
        }

        private static void OnCheckedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            bool? isChecked = e.NewValue as bool?;
            ((CustomCheckBox)d).bdChecked.Background = isChecked == true ? Brushes.Black : Brushes.White;
        }

        public string Number
        {
            get => GetValue(NumberProperty) as string;
            set => SetValue(NumberProperty, value);
        }

        private static void OnNumberPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            string number = (string)e.NewValue;
            ((CustomCheckBox)d).tbNumber.Text = number;
        }

        public string Title
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }

        private static void OnTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            string title = (string)e.NewValue;
            ((CustomCheckBox)d).tbTitle.Text = title;
        }

        public string Value
        {
            get => GetValue(ValueProperty) as string;
            set => SetValue(ValueProperty, value);
        }

        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            string value = (string)e.NewValue;
            ((CustomCheckBox)d).Checked = value == ((CustomCheckBox)d).Number;
        }

        public CustomCheckBox()
        {
            InitializeComponent();
        }

        private void BdChecked_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Value = Value == Number ? "" : Number;
        }
    }
}
