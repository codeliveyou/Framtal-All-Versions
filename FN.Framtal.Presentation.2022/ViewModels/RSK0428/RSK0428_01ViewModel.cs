using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK428_TENGDIR_LOGADILAR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T428_TL_NAFN { get; set; }
        public string K428_TL_KENNITALA { get; set; }
        public string T428_TL_TIN_NUMER { get; set; }
        public string R428_TL_LAND { get; set; }
        public string R428_TL_FORM_TENGSLA { get; set; }
        public string R428_TL_TEGUND_VIDSKIPTA { get; set; }
        public string R428_TL_FJARHAED_VIDSKIPTA { get; set; }
        public string C428_TL_VIDSKIPTI_SKJOLUD { get; set; }
        public RSK428_TENGDIR_LOGADILAR_ITEM(
            string _KENNITALA,
            string _TEKJUAR,
            int _NR_FRAMTAL,
            int _LINUNR,
            string _T428_TL_NAFN,
            string _K428_TL_KENNITALA,
            string _T428_TL_TIN_NUMER,
            string _R428_TL_LAND,
            string _R428_TL_FORM_TENGSLA,
            string _R428_TL_TEGUND_VIDSKIPTA,
            string _R428_TL_FJARHAED_VIDSKIPTA,
            string _C428_TL_VIDSKIPTI_SKJOLUD)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T428_TL_NAFN = _T428_TL_NAFN;
            K428_TL_KENNITALA = _K428_TL_KENNITALA;
            T428_TL_TIN_NUMER = _T428_TL_TIN_NUMER;
            R428_TL_LAND = _R428_TL_LAND;
            R428_TL_FORM_TENGSLA = _R428_TL_FORM_TENGSLA;
            R428_TL_TEGUND_VIDSKIPTA = _R428_TL_TEGUND_VIDSKIPTA;
            R428_TL_FJARHAED_VIDSKIPTA = _R428_TL_FJARHAED_VIDSKIPTA;
            C428_TL_VIDSKIPTI_SKJOLUD = _C428_TL_VIDSKIPTI_SKJOLUD;
        }
    }

    public class RSK0428_01ViewModel : ViewModelBase
    {
        BindingList<RSK428_TENGDIR_LOGADILAR_ITEM> _RSK428_TENGDIR_LOGADILAR;

        public BindingList<RSK428_TENGDIR_LOGADILAR_ITEM> RSK428_TENGDIR_LOGADILAR
        {
            get
            {
                return _RSK428_TENGDIR_LOGADILAR;
            }
            set
            {
                _RSK428_TENGDIR_LOGADILAR = value;
                OnPropertyChanged();
            }
        }

        public RSK0428_01ViewModel()
        {
        }
    }
}