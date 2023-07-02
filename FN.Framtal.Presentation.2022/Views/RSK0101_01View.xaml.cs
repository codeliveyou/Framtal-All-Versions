using FN.Framtal.Presentation._2022.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace FN.Framtal.Presentation._2022.Views
{
    /// <summary>
    /// Interaction logic for RSK0101_01View.xaml
    /// </summary>
    public partial class RSK0101_01View : Page
    {
        public RSK0101_01View()
        {
            InitializeComponent();
            DataContext = new RSK0101_01ViewModel();
        }
    }
}
