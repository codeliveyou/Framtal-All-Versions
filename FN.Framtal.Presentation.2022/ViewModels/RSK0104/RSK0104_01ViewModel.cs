using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public class RSK0104_01ViewModel : ViewModelBase
    {
        string _SELECTED_FRAMTAL = "";
        public string SELECTED_FRAMTAL
        {
            get { return _SELECTED_FRAMTAL; }
            set
            {
                _SELECTED_FRAMTAL = value;
                OnPropertyChanged();
            }
        }
        string _SELECTED_ARITUN = "";
        public string SELECTED_ARITUN
        {
            get { return _SELECTED_ARITUN; }
            set
            {
                _SELECTED_ARITUN = value;
                OnPropertyChanged();
            }
        }
        public RSK0104_01ViewModel()
        {
        }
    }
}