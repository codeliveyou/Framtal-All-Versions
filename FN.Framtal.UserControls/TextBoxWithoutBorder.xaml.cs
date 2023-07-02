using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for TextBoxWithoutBorder.xaml
    /// </summary>
    public partial class TextBoxWithoutBorder : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(TextBoxWithoutBorder), new PropertyMetadata(OnTextPropertyChanged));
        public event RoutedEventHandler TextChanged;

        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }

        public TextBoxWithoutBorder()
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
            ((TextBoxWithoutBorder)d).TextBox.Text = e.NewValue as string;
        }
    }
}
