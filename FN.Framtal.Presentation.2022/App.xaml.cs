using FN.Framtal.Presentation._2022.Stores;
using FN.Framtal.Presentation._2022.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FN.Framtal.Presentation._2022
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public enum Skin { Red, Blue, Green, Yellow };

    public partial class App : Application
    {
        private static Skin _skin;

        private readonly NavigationStore _navigationStore;

        public static Skin Skin { get => _skin; set => _skin = value; }

        public App()
        {
            string? config_skin = ConfigurationManager.AppSettings["Skin"];
            Enum.TryParse(config_skin, out _skin);
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new RSK0104_01ViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
