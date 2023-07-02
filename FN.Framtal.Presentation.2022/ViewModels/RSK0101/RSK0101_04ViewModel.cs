using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK101_4_ERLENDAR_FASTEIGNIR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_EF_LYSING_EIGNAR { get; set; }
        public string R101_EF_LAND_EIGNAR { get; set; }
        public int N101_EF_FJARHAED_EIGNAR { get; set; }
        public RSK101_4_ERLENDAR_FASTEIGNIR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_EF_LYSING_EIGNAR, string _R101_EF_LAND_EIGNAR, int _N101_EF_FJARHAED_EIGNAR)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_EF_LYSING_EIGNAR = _T101_EF_LYSING_EIGNAR;
            R101_EF_LAND_EIGNAR = _R101_EF_LAND_EIGNAR;
            N101_EF_FJARHAED_EIGNAR = _N101_EF_FJARHAED_EIGNAR;
        }
    }
    public struct RSK101_4_ADRAR_EIGNIR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T101_AE_SKRANINGARNUMER { get; set; }
        public string T101_AE_HVADA_EIGNIR { get; set; }
        public int N101_AE_FJARHAED { get; set; }
        public string RSK_AE_UPPRUNI { get; set; }
        public int RSK_AE_TEGUND_EIGNAR { get; set; }
        public RSK101_4_ADRAR_EIGNIR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _T101_AE_SKRANINGARNUMER, string _T101_AE_HVADA_EIGNIR, int _N101_AE_FJARHAED, string _RSK_AE_UPPRUNI, int _RSK_AE_TEGUND_EIGNAR)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T101_AE_SKRANINGARNUMER = _T101_AE_SKRANINGARNUMER;
            T101_AE_HVADA_EIGNIR = _T101_AE_HVADA_EIGNIR;
            N101_AE_FJARHAED = _N101_AE_FJARHAED;
            RSK_AE_UPPRUNI = _RSK_AE_UPPRUNI;
            RSK_AE_TEGUND_EIGNAR = _RSK_AE_TEGUND_EIGNAR;
        }
    }

    public struct RSK101_4_VAXTAGJOLD_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_VX_KT_SKULDAREIG { get; set; }
        public string T101_VX_SKULDAREIG { get; set; }
        public string A101_VX_AR { get; set; }
        public int N101_VX_LANSTIMI { get; set; }
        public int N101_VX_HEILDARGR { get; set; }
        public int N101_VX_AFBORGUN { get; set; }
        public int N101_VX_AFFOLL { get; set; }
        public int N101_VX_LANTOKUKOSTN { get; set; }
        public int N101_VX_VAXTAGJ { get; set; }
        public int N101_VX_EFTIRST { get; set; }
        public string K101_VX_LANSNUMER { get; set; }
        public int D101_VX_LANTOKUDAGUR { get; set; }//
        public int D101_VX_YFIRTOKUDAGUR { get; set; }//
        public string RSK_VX_UPPRUNI { get; set; }
        public int N101_VX_HLUTFALL { get; set; }
        public int N101_VX_HLUTFALL_VAXTAGJ { get; set; }
        public int N101_VX_HLUTFALL_EFTIRST { get; set; }
        public RSK101_4_VAXTAGJOLD_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_VX_KT_SKULDAREIG, string _T101_VX_SKULDAREIG, string _A101_VX_AR, int _N101_VX_LANSTIMI, int _N101_VX_HEILDARGR, int _N101_VX_AFBORGUN, int _N101_VX_AFFOLL, int _N101_VX_LANTOKUKOSTN, int _N101_VX_VAXTAGJ, int _N101_VX_EFTIRST, string _K101_VX_LANSNUMER, int _D101_VX_LANTOKUDAGUR, int _D101_VX_YFIRTOKUDAGUR, string _RSK_VX_UPPRUNI, int _N101_VX_HLUTFALL, int _N101_VX_HLUTFALL_VAXTAGJ, int _N101_VX_HLUTFALL_EFTIRST)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_VX_KT_SKULDAREIG = _K101_VX_KT_SKULDAREIG;
            T101_VX_SKULDAREIG = _T101_VX_SKULDAREIG;
            A101_VX_AR = _A101_VX_AR;
            N101_VX_LANSTIMI = _N101_VX_LANSTIMI;
            N101_VX_HEILDARGR = _N101_VX_HEILDARGR;
            N101_VX_AFBORGUN = _N101_VX_AFBORGUN;
            N101_VX_AFFOLL = _N101_VX_AFFOLL;
            N101_VX_LANTOKUKOSTN = _N101_VX_LANTOKUKOSTN;
            N101_VX_VAXTAGJ = _N101_VX_VAXTAGJ;
            N101_VX_EFTIRST = _N101_VX_EFTIRST;
            K101_VX_LANSNUMER = _K101_VX_LANSNUMER;
            D101_VX_LANTOKUDAGUR = _D101_VX_LANTOKUDAGUR;
            D101_VX_YFIRTOKUDAGUR = _D101_VX_YFIRTOKUDAGUR;
            RSK_VX_UPPRUNI = _RSK_VX_UPPRUNI;
            N101_VX_HLUTFALL = _N101_VX_HLUTFALL;
            N101_VX_HLUTFALL_VAXTAGJ = _N101_VX_HLUTFALL_VAXTAGJ;
            N101_VX_HLUTFALL_EFTIRST = _N101_VX_HLUTFALL_EFTIRST;
        }
    }
    public struct RSK101_4_ADRAR_SKULDIR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K101_AS_KT_SKULDAREIG { get; set; }
        public string T101_AS_SKULDAREIG { get; set; }
        public int N101_AS_VAXTAGJ { get; set; }
        public int N101_AS_EFTIRST { get; set; }
        public string RSK_AS_UPPRUNI { get; set; }
        public string K101_AS_LANSNUMER { get; set; }
        public RSK101_4_ADRAR_SKULDIR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K101_AS_KT_SKULDAREIG, string _T101_AS_SKULDAREIG, int _N101_AS_VAXTAGJ, int _N101_AS_EFTIRST, string _RSK_AS_UPPRUNI, string _K101_AS_LANSNUMER)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K101_AS_KT_SKULDAREIG = _K101_AS_KT_SKULDAREIG;
            T101_AS_SKULDAREIG = _T101_AS_SKULDAREIG;
            N101_AS_VAXTAGJ = _N101_AS_VAXTAGJ;
            N101_AS_EFTIRST = _N101_AS_EFTIRST;
            RSK_AS_UPPRUNI = _RSK_AS_UPPRUNI;
            K101_AS_LANSNUMER = _K101_AS_LANSNUMER;
        }
    }

    public class RSK0101_04ViewModel : ViewModelBase
    {
        BindingList<RSK101_4_ERLENDAR_FASTEIGNIR_ITEM> _RSK101_4_ERLENDAR_FASTEIGNIR;
        BindingList<RSK101_4_ADRAR_EIGNIR_ITEM> _RSK101_4_ADRAR_EIGNIR;

        BindingList<RSK101_4_VAXTAGJOLD_ITEM> _RSK101_4_VAXTAGJOLD;
        BindingList<RSK101_4_ADRAR_SKULDIR_ITEM> _RSK101_4_ADRAR_SKULDIR;

        public BindingList<RSK101_4_ERLENDAR_FASTEIGNIR_ITEM> RSK101_4_ERLENDAR_FASTEIGNIR
        {
            get
            {
                return _RSK101_4_ERLENDAR_FASTEIGNIR;
            }
            set
            {
                _RSK101_4_ERLENDAR_FASTEIGNIR = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_4_ADRAR_EIGNIR_ITEM> RSK101_4_ADRAR_EIGNIR
        {
            get
            {
                return _RSK101_4_ADRAR_EIGNIR;
            }
            set
            {
                _RSK101_4_ADRAR_EIGNIR = value;
                OnPropertyChanged();
            }
        }

        public BindingList<RSK101_4_VAXTAGJOLD_ITEM> RSK101_4_VAXTAGJOLD
        {
            get
            {
                return _RSK101_4_VAXTAGJOLD;
            }
            set
            {
                _RSK101_4_VAXTAGJOLD = value;
                OnPropertyChanged();
            }
        }
        public BindingList<RSK101_4_ADRAR_SKULDIR_ITEM> RSK101_4_ADRAR_SKULDIR
        {
            get
            {
                return _RSK101_4_ADRAR_SKULDIR;
            }
            set
            {
                _RSK101_4_ADRAR_SKULDIR = value;
                OnPropertyChanged();
            }
        }

        public RSK0101_04ViewModel()
        {
        }
    }
}