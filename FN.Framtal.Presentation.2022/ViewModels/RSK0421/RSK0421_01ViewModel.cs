using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK421_ADKEYPT_VINNA_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int BLADANR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T421_KV_NAFN_SELJANDA { get; set; }
        public string K421_KV_KENNITALA { get; set; }
        public string T421_KV_HVADA_VINNA { get; set; }
        public int N421_KV_FJARHAED { get; set; }
        public RSK421_ADKEYPT_VINNA_ITEM(
            string _KENNITALA,
            string _TEKJUAR,
            int _BLADANR,
            int _NR_FRAMTAL,
            int _LINUNR,
            string _T421_KV_NAFN_SELJANDA,
            string _K421_KV_KENNITALA,
            string _T421_KV_HVADA_VINNA,
            int _N421_KV_FJARHAED)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            BLADANR = _BLADANR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T421_KV_NAFN_SELJANDA = _T421_KV_NAFN_SELJANDA;
            K421_KV_KENNITALA = _K421_KV_KENNITALA;
            T421_KV_HVADA_VINNA = _T421_KV_HVADA_VINNA;
            N421_KV_FJARHAED = _N421_KV_FJARHAED;
        }
    }

    public struct RSK421_OPINBERIR_STYRKIR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int BLADANR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T421_OS_GREIDANDI_NAFN { get; set; }
        public string K421_OS_GREIDANDI_KENNITALA { get; set; }
        public int N421_OS_FJARHAED { get; set; }
        public RSK421_OPINBERIR_STYRKIR_ITEM(
            string _KENNITALA,
            string _TEKJUAR,
            int _BLADANR,
            int _NR_FRAMTAL,
            int _LINUNR,
            string _T421_OS_GREIDANDI_NAFN,
            string _K421_OS_GREIDANDI_KENNITALA,
            int _N421_OS_FJARHAED)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            BLADANR = _BLADANR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T421_OS_GREIDANDI_NAFN = _T421_OS_GREIDANDI_NAFN;
            K421_OS_GREIDANDI_KENNITALA = _K421_OS_GREIDANDI_KENNITALA;
            N421_OS_FJARHAED = _N421_OS_FJARHAED;
        }
    }


    public class RSK0421_01ViewModel : ViewModelBase
    {
        private BindingList<RSK421_ADKEYPT_VINNA_ITEM> _RSK421_ADKEYPT_VINNA;

        private BindingList<RSK421_OPINBERIR_STYRKIR_ITEM> _RSK421_OPINBERIR_STYRKIR;



        public BindingList<RSK421_ADKEYPT_VINNA_ITEM> RSK421_ADKEYPT_VINNA
        {
            get
            {
                return _RSK421_ADKEYPT_VINNA;
            }
            set
            {
                _RSK421_ADKEYPT_VINNA = value;
                OnPropertyChanged();
            }
        }

        public BindingList<RSK421_OPINBERIR_STYRKIR_ITEM> RSK421_OPINBERIR_STYRKIR
        {
            get
            {
                return _RSK421_OPINBERIR_STYRKIR;
            }
            set
            {
                _RSK421_OPINBERIR_STYRKIR = value;
                OnPropertyChanged();
            }
        }


        public RSK0421_01ViewModel()
        {

        }
    }
}
