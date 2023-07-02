using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for NumericTextBoxWithoutBorder.xaml
    /// </summary>
    public partial class NumericTextBoxWithoutBorder : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(NumericTextBoxWithoutBorder), new PropertyMetadata(OnTextPropertyChanged));
        public event RoutedEventHandler TextChanged;

        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }
        
        public NumericTextBoxWithoutBorder()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Text = TextBox.Text;
            if (TextChanged != null)
            {
                TextChanged(this, e);
            }
        }
        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((NumericTextBoxWithoutBorder)d).TextBox.Text = e.NewValue as string;
        }

    }
}
