using System.ComponentModel;


namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK329_FRADRATTARB_FJARFESTING_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T329_FF_NAFN_FELAGS { get; set; }
        public string K329_FF_KENNITALA_FELAGS { get; set; }
        public int D329_FF_KAUPDAGUR { get; set; }
        public int N329_FF_NAFNVERD_HLUTABREFA { get; set; }


        public int N329_FF_KAUPVERD { get; set; }
        public RSK329_FRADRATTARB_FJARFESTING_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T329_FF_NAFN_FELAGS, string _K329_FF_KENNITALA_FELAGS, int _D329_FF_KAUPDAGUR, int _N329_FF_NAFNVERD_HLUTABREFA, int _N329_FF_KAUPVERD)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T329_FF_NAFN_FELAGS = _T329_FF_NAFN_FELAGS;
            K329_FF_KENNITALA_FELAGS = _K329_FF_KENNITALA_FELAGS;
            D329_FF_KAUPDAGUR = _D329_FF_KAUPDAGUR;
            N329_FF_NAFNVERD_HLUTABREFA = _N329_FF_NAFNVERD_HLUTABREFA;
            N329_FF_KAUPVERD = _N329_FF_KAUPVERD;
        }
    }


    public class RSK0329_01ViewModel : ViewModelBase
    {
        private BindingList<RSK329_FRADRATTARB_FJARFESTING_ITEM> _RSK329_FRADRATTARB_FJARFESTING;


        public BindingList<RSK329_FRADRATTARB_FJARFESTING_ITEM> RSK329_FRADRATTARB_FJARFESTING
        {
            get
            {
                return _RSK329_FRADRATTARB_FJARFESTING;
            }
            set
            {
                _RSK329_FRADRATTARB_FJARFESTING = value;
                OnPropertyChanged();
            }
        }

        public RSK0329_01ViewModel()
        {
            
        }
    }
}
