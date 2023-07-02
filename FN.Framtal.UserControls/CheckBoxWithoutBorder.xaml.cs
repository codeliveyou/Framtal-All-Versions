using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for CheckBoxWithoutBorder.xaml
    /// </summary>
    public partial class CheckBoxWithoutBorder : UserControl
    {
        public event RoutedEventHandler CheckedChange;

        public CheckBoxWithoutBorder()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckedChange != null)
            {
                CheckedChange(this, e);
            }
        }

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(CheckBoxWithoutBorder));
    }
}
