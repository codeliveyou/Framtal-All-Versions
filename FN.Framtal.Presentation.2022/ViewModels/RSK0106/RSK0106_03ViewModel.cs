using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK106_VEXTIR_INNLENDIR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T106_VI_SKYRING { get; set; }
        public int N106_VI_R89_STADGREIDSLA { get; set; }
        public int N106_VI_R30_VEXTIR { get; set; }
        public int N106_VI_EIGN { get; set; }
        public RSK106_VEXTIR_INNLENDIR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T106_VI_SKYRING, int _N106_VI_R89_STADGREIDSLA, int _N106_VI_R30_VEXTIR, int _N106_VI_EIGN)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T106_VI_SKYRING = _T106_VI_SKYRING;
            N106_VI_R89_STADGREIDSLA = _N106_VI_R89_STADGREIDSLA;
            N106_VI_R30_VEXTIR = _N106_VI_R30_VEXTIR;
            N106_VI_EIGN = _N106_VI_EIGN;
        }
    }
    public struct RSK106_VEXTIR_ERLENDIR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T106_VE_SKYRING { get; set; }
        public int N106_VE_R91_STADGREIDSLA { get; set; }
        public int N106_VE_R31_VEXTIR { get; set; }
        public int N106_VE_EIGN { get; set; }
        public RSK106_VEXTIR_ERLENDIR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T106_VE_SKYRING, int _N106_VE_R91_STADGREIDSLA, int _N106_VE_R31_VEXTIR, int _N106_VE_EIGN)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T106_VE_SKYRING = _T106_VE_SKYRING;
            N106_VE_R91_STADGREIDSLA = _N106_VE_R91_STADGREIDSLA;
            N106_VE_R31_VEXTIR = _N106_VE_R31_VEXTIR;
            N106_VE_EIGN = _N106_VE_EIGN;
        }
    }
    public struct RSK106_HLUTABREF_INNLEND_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K106_HI_KENNITALA_FELAGS { get; set; }
        public string T106_HI_NAFN_FELAGS { get; set; }
        public int N106_HI_R92_STADGREIDSLA { get; set; }
        public int N106_HI_R32_ARDUR { get; set; }
        public int N106_HI_EIGN { get; set; }
        public RSK106_HLUTABREF_INNLEND_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K106_HI_KENNITALA_FELAGS, string _T106_HI_NAFN_FELAGS, int _N106_HI_R92_STADGREIDSLA, int _N106_HI_R32_ARDUR, int _N106_HI_EIGN)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K106_HI_KENNITALA_FELAGS = _K106_HI_KENNITALA_FELAGS;
            T106_HI_NAFN_FELAGS = _T106_HI_NAFN_FELAGS;
            N106_HI_R92_STADGREIDSLA = _N106_HI_R92_STADGREIDSLA;
            N106_HI_R32_ARDUR = _N106_HI_R32_ARDUR;
            N106_HI_EIGN = _N106_HI_EIGN;
        }
    }
    public struct RSK106_HLUTABREF_ERLEND_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T106_HU_NAFN_FELAGS { get; set; }
        public string R106_HU_LAND { get; set; }
        public int N106_HU_R36_ARDUR { get; set; }
        public int N106_HU_EIGN { get; set; }
        public RSK106_HLUTABREF_ERLEND_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T106_HU_NAFN_FELAGS, string _R106_HU_LAND, int _N106_HU_R36_ARDUR, int _N106_HU_EIGN)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T106_HU_NAFN_FELAGS = _T106_HU_NAFN_FELAGS;
            R106_HU_LAND = _R106_HU_LAND;
            N106_HU_R36_ARDUR = _N106_HU_R36_ARDUR;
            N106_HU_EIGN = _N106_HU_EIGN;
        }
    }

    public class RSK0106_03ViewModel : ViewModelBase
    {
        BindingList<RSK106_VEXTIR_INNLENDIR_ITEM> _RSK106_VEXTIR_INNLENDIR;
        BindingList<RSK106_VEXTIR_ERLENDIR_ITEM> _RSK106_VEXTIR_ERLENDIR;
        BindingList<RSK106_HLUTABREF_INNLEND_ITEM> _RSK106_HLUTABREF_INNLEND;
        BindingList<RSK106_HLUTABREF_ERLEND_ITEM> _RSK106_HLUTABREF_ERLEND;

        public BindingList<RSK106_VEXTIR_INNLENDIR_ITEM> RSK106_VEXTIR_INNLENDIR
        {
            get
            {
                return _RSK106_VEXTIR_INNLENDIR;
            }
            set
            {
                _RSK106_VEXTIR_INNLENDIR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK106_VEXTIR_ERLENDIR_ITEM> RSK106_VEXTIR_ERLENDIR
        {
            get
            {
                return _RSK106_VEXTIR_ERLENDIR;
            }
            set
            {
                _RSK106_VEXTIR_ERLENDIR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK106_HLUTABREF_INNLEND_ITEM> RSK106_HLUTABREF_INNLEND
        {
            get
            {
                return _RSK106_HLUTABREF_INNLEND;
            }
            set
            {
                _RSK106_HLUTABREF_INNLEND = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK106_HLUTABREF_ERLEND_ITEM> RSK106_HLUTABREF_ERLEND
        {
            get
            {
                return _RSK106_HLUTABREF_ERLEND;
            }
            set
            {
                _RSK106_HLUTABREF_ERLEND = value;
                OnPropertyChanged();
            }
        }

        public RSK0106_03ViewModel()
        {
            
        }
    }
}