using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK101_3_INNLENDIR_BANKAR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_IB_KT_BANKI { get; set; }
        public string T101_IB_BANKI { get; set; }
        public int N101_IB_VEXTIR { get; set; }
        public int N101_IB_EIGN { get; set; }
        public int N101_IB_STADGREIDSLA { get; set; }
        public string RSK_IB_UPPRUNI { get; set; }
        public RSK101_3_INNLENDIR_BANKAR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_IB_KT_BANKI, string _T101_IB_BANKI, int _N101_IB_VEXTIR, int _N101_IB_EIGN, int _N101_IB_STADGREIDSLA, string _RSK_IB_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_IB_KT_BANKI = _K101_IB_KT_BANKI;
            T101_IB_BANKI = _T101_IB_BANKI;
            N101_IB_VEXTIR = _N101_IB_VEXTIR;
            N101_IB_EIGN = _N101_IB_EIGN;
            N101_IB_STADGREIDSLA = _N101_IB_STADGREIDSLA;
            RSK_IB_UPPRUNI = _RSK_IB_UPPRUNI;
        }
    }
    public struct RSK101_3_ERLENDIR_BANKAR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_EB_BANKI { get; set; }
        public int N101_EB_VEXTIR { get; set; }
        public int N101_EB_EIGN { get; set; }
        public string R101_EB_LAND { get; set; }
        public RSK101_3_ERLENDIR_BANKAR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_EB_BANKI, int _N101_EB_VEXTIR, int _N101_EB_EIGN, string _R101_EB_LAND)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_EB_BANKI = _T101_EB_BANKI;
            N101_EB_VEXTIR = _N101_EB_VEXTIR;
            N101_EB_EIGN = _N101_EB_EIGN;
            R101_EB_LAND = _R101_EB_LAND;
        }
    }
    public struct RSK101_3_RIKIS_VERDBREF_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_RV_RIKISVERDBR { get; set; }
        public int N101_RV_VEXTIR { get; set; }
        public int N101_RV_EIGN { get; set; }
        public int N101_RV_STADGREIDSLA { get; set; }
        public string RSK_RV_UPPRUNI { get; set; }
        public RSK101_3_RIKIS_VERDBREF_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_RV_RIKISVERDBR, int _N101_RV_VEXTIR, int _N101_RV_EIGN, int _N101_RV_STADGREIDSLA, string _RSK_RV_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_RV_RIKISVERDBR = _T101_RV_RIKISVERDBR;
            N101_RV_VEXTIR = _N101_RV_VEXTIR;
            N101_RV_EIGN = _N101_RV_EIGN;
            N101_RV_STADGREIDSLA = _N101_RV_STADGREIDSLA;
            RSK_RV_UPPRUNI = _RSK_RV_UPPRUNI;
        }
    }
    public struct RSK101_3_BORN_BANKAR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_BB_KT_BANKI { get; set; }
        public string T101_BB_BANKI { get; set; }
        public int N101_BB_VEXTIR { get; set; }
        public int N101_BB_EIGN { get; set; }
        public int N101_BB_STADGREIDSLA { get; set; }
        public string RSK_BB_UPPRUNI { get; set; }
        public RSK101_3_BORN_BANKAR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_BB_KT_BANKI, string _T101_BB_BANKI, int _N101_BB_VEXTIR, int _N101_BB_EIGN, int _N101_BB_STADGREIDSLA, string _RSK_BB_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_BB_KT_BANKI = _K101_BB_KT_BANKI;
            T101_BB_BANKI = _T101_BB_BANKI;
            N101_BB_VEXTIR = _N101_BB_VEXTIR;
            N101_BB_EIGN = _N101_BB_EIGN;
            N101_BB_STADGREIDSLA = _N101_BB_STADGREIDSLA;
            RSK_BB_UPPRUNI = _RSK_BB_UPPRUNI;
        }
    }
    public struct RSK101_3_HLUTABREF_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_HB_KT_HLUTAFEL { get; set; }
        public string T101_HB_HLUTABREF { get; set; }
        public int N101_HB_ARDUR { get; set; }
        public int N101_HB_EIGN { get; set; }
        public int N101_HB_STADGREIDSLA { get; set; }
        public RSK101_3_HLUTABREF_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_HB_KT_HLUTAFEL, string _T101_HB_HLUTABREF, int _N101_HB_ARDUR, int _N101_HB_EIGN, int _N101_HB_STADGREIDSLA)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_HB_KT_HLUTAFEL = _K101_HB_KT_HLUTAFEL;
            T101_HB_HLUTABREF = _T101_HB_HLUTABREF;
            N101_HB_ARDUR = _N101_HB_ARDUR;
            N101_HB_EIGN = _N101_HB_EIGN;
            N101_HB_STADGREIDSLA = _N101_HB_STADGREIDSLA;
        }
    }
    public struct RSK101_3_ERLEND_HLUTABREF_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_EH_HLUTABREF { get; set; }
        public int N101_EH_ARDUR { get; set; }
        public int N101_EH_EIGN { get; set; }
        public string R101_EH_LAND { get; set; }
        public RSK101_3_ERLEND_HLUTABREF_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_EH_HLUTABREF, int _N101_EH_ARDUR, int _N101_EH_EIGN, string _R101_EH_LAND)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_EH_HLUTABREF = _T101_EH_HLUTABREF;
            N101_EH_ARDUR = _N101_EH_ARDUR;
            N101_EH_EIGN = _N101_EH_EIGN;
            R101_EH_LAND = _R101_EH_LAND;
        }
    }
    public struct RSK101_3_HOFUNDARRETTARGREIDSL_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_HG_KT_GREIDANDI { get; set; }
        public string T101_HG_GREIDANDI { get; set; }
        public int N101_HG_STADGREIDSLA { get; set; }
        public int N101_HG_GREIDSLA { get; set; }
        public string T101_HG_TEGUND_GREIDSLU { get; set; }
        public string R101_HG_LAND { get; set; }
        public string RSK_HG_KT_EIGN_FAERSLU { get; set; }
        public RSK101_3_HOFUNDARRETTARGREIDSL_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_HG_KT_GREIDANDI, string _T101_HG_GREIDANDI, int _N101_HG_STADGREIDSLA, int _N101_HG_GREIDSLA, string _T101_HG_TEGUND_GREIDSLU, string _R101_HG_LAND, string _RSK_HG_KT_EIGN_FAERSLU)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_HG_KT_GREIDANDI = _K101_HG_KT_GREIDANDI;
            T101_HG_GREIDANDI = _T101_HG_GREIDANDI;
            N101_HG_STADGREIDSLA = _N101_HG_STADGREIDSLA;
            N101_HG_GREIDSLA = _N101_HG_GREIDSLA;
            T101_HG_TEGUND_GREIDSLU = _T101_HG_TEGUND_GREIDSLU;
            R101_HG_LAND = _R101_HG_LAND;
            RSK_HG_KT_EIGN_FAERSLU = _RSK_HG_KT_EIGN_FAERSLU;
        }
    }

    public class RSK0101_03ViewModel : ViewModelBase
    {
        BindingList<RSK101_3_INNLENDIR_BANKAR_ITEM> _RSK101_3_INNLENDIR_BANKAR;
        BindingList<RSK101_3_ERLENDIR_BANKAR_ITEM> _RSK101_3_ERLENDIR_BANKAR;
        BindingList<RSK101_3_RIKIS_VERDBREF_ITEM> _RSK101_3_RIKIS_VERDBREF;
        BindingList<RSK101_3_BORN_BANKAR_ITEM> _RSK101_3_BORN_BANKAR;
        BindingList<RSK101_3_HLUTABREF_ITEM> _RSK101_3_HLUTABREF;
        BindingList<RSK101_3_ERLEND_HLUTABREF_ITEM> _RSK101_3_ERLEND_HLUTABREF;
        BindingList<RSK101_3_HOFUNDARRETTARGREIDSL_ITEM> _RSK101_3_HOFUNDARRETTARGREIDSL;

        public BindingList<RSK101_3_INNLENDIR_BANKAR_ITEM> RSK101_3_INNLENDIR_BANKAR
        {
            get
            {
                return _RSK101_3_INNLENDIR_BANKAR;
            }
            set
            {
                _RSK101_3_INNLENDIR_BANKAR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_3_ERLENDIR_BANKAR_ITEM> RSK101_3_ERLENDIR_BANKAR
        {
            get
            {
                return _RSK101_3_ERLENDIR_BANKAR;
            }
            set
            {
                _RSK101_3_ERLENDIR_BANKAR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_3_RIKIS_VERDBREF_ITEM> RSK101_3_RIKIS_VERDBREF
        {
            get
            {
                return _RSK101_3_RIKIS_VERDBREF;
            }
            set
            {
                _RSK101_3_RIKIS_VERDBREF = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_3_BORN_BANKAR_ITEM> RSK101_3_BORN_BANKAR
        {
            get
            {
                return _RSK101_3_BORN_BANKAR;
            }
            set
            {
                _RSK101_3_BORN_BANKAR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_3_HLUTABREF_ITEM> RSK101_3_HLUTABREF
        {
            get
            {
                return _RSK101_3_HLUTABREF;
            }
            set
            {
                _RSK101_3_HLUTABREF = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_3_ERLEND_HLUTABREF_ITEM> RSK101_3_ERLEND_HLUTABREF
        {
            get
            {
                return _RSK101_3_ERLEND_HLUTABREF;
            }
            set
            {
                _RSK101_3_ERLEND_HLUTABREF = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_3_HOFUNDARRETTARGREIDSL_ITEM> RSK101_3_HOFUNDARRETTARGREIDSL
        {
            get
            {
                return _RSK101_3_HOFUNDARRETTARGREIDSL;
            }
            set
            {
                _RSK101_3_HOFUNDARRETTARGREIDSL = value;
                OnPropertyChanged();
            }
        }

        public RSK0101_03ViewModel()
        {
        }
    }
}