using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK0101_1_BORN_ITEM
    {
        public string T101_BO_BARN { get; set; }
        public string K101_BO_KT_BARN { get; set; }
        public int RSK_BO_UPPRUNI { get; set; }

        public RSK0101_1_BORN_ITEM(string _T101_BO_BARN, string _K101_BO_KT_BARN, int _RSK_BO_UPPRUNI)
        {
            T101_BO_BARN = _T101_BO_BARN;
            K101_BO_KT_BARN = _K101_BO_KT_BARN;
            RSK_BO_UPPRUNI = _RSK_BO_UPPRUNI;
        }
    }

    public struct RSK101_1_UMSOKN_UM_LAEKKUN_ITEM
    {
        public string T101_UL_SKOLI { get; set; }
        public string K101_UL_R527 { get; set; }
        public string N101_UL_R528 { get; set; }

        public RSK101_1_UMSOKN_UM_LAEKKUN_ITEM(string _T101_UL_SKOLI, string _K101_UL_R527, string _N101_UL_R528)
        {
            T101_UL_SKOLI = _T101_UL_SKOLI;
            K101_UL_R527 = _K101_UL_R527;
            N101_UL_R528 = _N101_UL_R528;
        }
    }

    public struct RSK101_1_ARFUR_ITEM
    {
        public string K101_AR_KENNITALA_ARFLATA { get; set; }
        public string N101_AR_ARFUR { get; set; }
        public int N101_AR_ERFDAFJARSKATTUR { get; set; }
        public int RSK_AR_UPPRUNI { get; set; }

        public RSK101_1_ARFUR_ITEM(string _K101_AR_KENNITALA_ARFLATA, string _N101_AR_ARFUR, int _N101_AR_ERFDAFJARSKATTUR, int _RSK_AR_UPPRUNI)
        {
            K101_AR_KENNITALA_ARFLATA = _K101_AR_KENNITALA_ARFLATA;
            N101_AR_ARFUR = _N101_AR_ARFUR;
            N101_AR_ERFDAFJARSKATTUR = _N101_AR_ERFDAFJARSKATTUR;
            RSK_AR_UPPRUNI = _RSK_AR_UPPRUNI;
        }
    }

    public class RSK0101_01ViewModel : ViewModelBase
    {
        bool _R101_UPPGJOR_ALAGNINGAR;
        bool _C101_SLYSATRYGGING;
        bool _C101_EINSTAETT_FOR;
        bool _C101_SAMSKOTTUN_OSK;
        string _K101_KENNITALA_SAMBUD = "";
        BindingList<RSK0101_1_BORN_ITEM> _RSK0101_1_BORN;
        BindingList<RSK101_1_UMSOKN_UM_LAEKKUN_ITEM> _RSK101_1_UMSOKN_UM_LAEKKUN;
        BindingList<RSK101_1_ARFUR_ITEM> _RSK101_1_ARFUR;
        string _M101_ATH2 = "";
        public bool R101_UPPGJOR_ALAGNINGAR
        {
            get
            {
                return _R101_UPPGJOR_ALAGNINGAR;
            }
            set
            {
                _R101_UPPGJOR_ALAGNINGAR = value;
                OnPropertyChanged();
            }
        }
        public bool C101_SLYSATRYGGING
        {
            get { return _C101_SLYSATRYGGING; }
            set
            {
                _C101_SLYSATRYGGING = value;
                OnPropertyChanged();
            }
        }
        public bool C101_EINSTAETT_FOR
        {
            get { return _C101_EINSTAETT_FOR; }
            set
            {
                _C101_EINSTAETT_FOR = value;
                OnPropertyChanged();
            }
        }

        public bool C101_SAMSKOTTUN_OSK
        {
            get { return _C101_SAMSKOTTUN_OSK; }
            set
            {
                _C101_SAMSKOTTUN_OSK = value;
                OnPropertyChanged();
            }
        }

        public string K101_KENNITALA_SAMBUD
        {
            get { return _K101_KENNITALA_SAMBUD; }
            set
            {
                _K101_KENNITALA_SAMBUD = value;
                OnPropertyChanged();
            }
        }

        public BindingList<RSK0101_1_BORN_ITEM> RSK0101_1_BORN
        {
            get { return _RSK0101_1_BORN; }
            set
            {
                _RSK0101_1_BORN = value;
                OnPropertyChanged();
            }
        }

        public BindingList<RSK101_1_UMSOKN_UM_LAEKKUN_ITEM> RSK101_1_UMSOKN_UM_LAEKKUN
        {
            get { return _RSK101_1_UMSOKN_UM_LAEKKUN; }
            set
            {
                _RSK101_1_UMSOKN_UM_LAEKKUN = value;
                OnPropertyChanged();
            }
        }

        public string M101_ATH2
        {
            get
            {
                return _M101_ATH2;
            }
            set
            {
                _M101_ATH2 = value;
                OnPropertyChanged();
            }
        }

        public BindingList<RSK101_1_ARFUR_ITEM> RSK101_1_ARFUR
        {
            get { return _RSK101_1_ARFUR; }
            set
            {
                _RSK101_1_ARFUR = value;
                OnPropertyChanged();
            }
        }

        public RSK0101_01ViewModel()
        {
        }
    }
}