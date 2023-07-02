using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for KennitalaWithoutBorder.xaml
    /// </summary>
    public partial class KennitalaWithoutBorder : UserControl
    {
        public KennitalaWithoutBorder()
        {
            InitializeComponent();
        }

        public string DeclarantIdentityNumber
        {
            get { return (string)GetValue(DeclarantIdentityNumberProperty); }
            set { SetValue(DeclarantIdentityNumberProperty, value); }
        }

        public static readonly DependencyProperty DeclarantIdentityNumberProperty =
            DependencyProperty.Register("DeclarantIdentityNumber", typeof(string), typeof(KennitalaWithoutBorder));

        public string SpouseSSN
        {
            get { return (string)GetValue(SpouseSSNProperty); }
            set { SetValue(SpouseSSNProperty, value); }
        }

        public static readonly DependencyProperty SpouseSSNProperty =
            DependencyProperty.Register("SpouseSSN", typeof(string), typeof(KennitalaWithoutBorder));
    }
}
