using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{

    public struct RSK401_EIGNASKRA_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int BLADANR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T401_ES_HEITI_EIGN { get; set; }
        public string A401_ES_KAUP_BYGG_AR { get; set; }
        public string R401_ES_FLOKKUR_FYRNINGAR { get; set; }
        public string R401_ES_TEGUND_FYRNINGAR { get; set; }
        public string T401_ES_RADNUMER_EIGNAR { get; set; }
        public string K401_ES_AUDKENNI_EIGNAR { get; set; }
        public string R401_ES_UPPRUNI { get; set; }
        public string R401_ES_RADSTOFUN { get; set; }
        public string K401_ES_KENNITALA_SELJANDA { get; set; }
        public int N401_ES_INNSKATTUR { get; set; }
        public int N401_ES_KAUPVERD_STOFNVERD { get; set; }
        public int N401_ES_BOKFAERT_VERD_UPPHAF { get; set; }
        public int N401_ES_FYRNINGARHLUTFALL { get; set; }
        public int N401_ES_ALMENN_FYRNING { get; set; }
        public int N401_ES_AUKAFYRNINGAR { get; set; }
        public int N401_ES_BOKFAERT_VERD_LOK { get; set; }
        public string K401_ES_KENNITALA_KAUPANDA { get; set; }
        public int N401_ES_SOLUVERD { get; set; }
        public int N401_ES_UTSKATTUR { get; set; }
        public int N401_ES_SOLUHAGNADUR_SOLUTAP { get; set; }
        public int N401_ES_FRESTADUR_SOLUHAGNADUR { get; set; }
        public string R401_ES_FLOKKUR_FRESTUNAR { get; set; }
        public string RSK_ES_UPPRUNI_GAGNA { get; set; }
        public string R401_ES_SKRANING { get; set; }
        public int N401_ES_INNSKATTSKVOD { get; set; }
        public string A401_ES_INNSKATTSKVOD { get; set; }
        public int N401_ES_STADA_INNSKATTSKVOD { get; set; }
        public string K401_ES_FASTANUMER_EIGNAR { get; set; }
        public string K401_ES_SKRANINGARNR { get; set; }
        public string C401_ES_EKKI_I_NOTKUN { get; set; }
        public string C401_ES_VISTVAENT_OKUTAEKI { get; set; }
        public string C401_ES_VISTVAENT_ANNAD { get; set; }
        public int N401_ES_VISTV_FYRNINGARALAG { get; set; }
        public string N401_ES_VSK_NUMER { get; set; }
        public RSK401_EIGNASKRA_ITEM(
                string _KENNITALA,
                string _TEKJUAR,
                int _BLADANR,
                int _NR_FRAMTAL,
                int _LINUNR,
                string _T401_ES_HEITI_EIGN,
                string _A401_ES_KAUP_BYGG_AR,
                string _R401_ES_FLOKKUR_FYRNINGAR,
                string _R401_ES_TEGUND_FYRNINGAR,
                string _T401_ES_RADNUMER_EIGNAR,
                string _K401_ES_AUDKENNI_EIGNAR,
                string _R401_ES_UPPRUNI,
                string _R401_ES_RADSTOFUN,
                string _K401_ES_KENNITALA_SELJANDA,
                int _N401_ES_INNSKATTUR,
                int _N401_ES_KAUPVERD_STOFNVERD,
                int _N401_ES_BOKFAERT_VERD_UPPHAF,
                int _N401_ES_FYRNINGARHLUTFALL,
                int _N401_ES_ALMENN_FYRNING,
                int _N401_ES_AUKAFYRNINGAR,
                int _N401_ES_BOKFAERT_VERD_LOK,
                string _K401_ES_KENNITALA_KAUPANDA,
                int _N401_ES_SOLUVERD,
                int _N401_ES_UTSKATTUR,
                int _N401_ES_SOLUHAGNADUR_SOLUTAP,
                int _N401_ES_FRESTADUR_SOLUHAGNADUR,
                string _R401_ES_FLOKKUR_FRESTUNAR,
                string _RSK_ES_UPPRUNI_GAGNA,
                string _R401_ES_SKRANING,
                int _N401_ES_INNSKATTSKVOD,
                string _A401_ES_INNSKATTSKVOD,
                int _N401_ES_STADA_INNSKATTSKVOD,
                string _K401_ES_FASTANUMER_EIGNAR,
                string _K401_ES_SKRANINGARNR,
                string _C401_ES_EKKI_I_NOTKUN,
                string _C401_ES_VISTVAENT_OKUTAEKI,
                string _C401_ES_VISTVAENT_ANNAD,
                int _N401_ES_VISTV_FYRNINGARALAG,
                string _N401_ES_VSK_NUMER) 
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            BLADANR = _BLADANR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T401_ES_HEITI_EIGN = _T401_ES_HEITI_EIGN;
            A401_ES_KAUP_BYGG_AR = _A401_ES_KAUP_BYGG_AR;
            R401_ES_FLOKKUR_FYRNINGAR = _R401_ES_FLOKKUR_FYRNINGAR;
            R401_ES_TEGUND_FYRNINGAR = _R401_ES_TEGUND_FYRNINGAR;
            T401_ES_RADNUMER_EIGNAR = _T401_ES_RADNUMER_EIGNAR;
            K401_ES_AUDKENNI_EIGNAR = _K401_ES_AUDKENNI_EIGNAR;
            R401_ES_UPPRUNI = _R401_ES_UPPRUNI;
            R401_ES_RADSTOFUN = _R401_ES_RADSTOFUN;
            K401_ES_KENNITALA_SELJANDA = _K401_ES_KENNITALA_SELJANDA;
            N401_ES_INNSKATTUR = _N401_ES_INNSKATTUR;
            N401_ES_KAUPVERD_STOFNVERD = _N401_ES_KAUPVERD_STOFNVERD;
            N401_ES_BOKFAERT_VERD_UPPHAF = _N401_ES_BOKFAERT_VERD_UPPHAF;
            N401_ES_FYRNINGARHLUTFALL = _N401_ES_FYRNINGARHLUTFALL;
            N401_ES_ALMENN_FYRNING = _N401_ES_ALMENN_FYRNING;
            N401_ES_AUKAFYRNINGAR = _N401_ES_AUKAFYRNINGAR;
            N401_ES_BOKFAERT_VERD_LOK = _N401_ES_BOKFAERT_VERD_LOK;
            K401_ES_KENNITALA_KAUPANDA = _K401_ES_KENNITALA_KAUPANDA;
            N401_ES_SOLUVERD = _N401_ES_SOLUVERD;
            N401_ES_UTSKATTUR = _N401_ES_UTSKATTUR;
            N401_ES_SOLUHAGNADUR_SOLUTAP = _N401_ES_SOLUHAGNADUR_SOLUTAP;
            N401_ES_FRESTADUR_SOLUHAGNADUR = _N401_ES_FRESTADUR_SOLUHAGNADUR;
            R401_ES_FLOKKUR_FRESTUNAR = _R401_ES_FLOKKUR_FRESTUNAR;
            RSK_ES_UPPRUNI_GAGNA = _RSK_ES_UPPRUNI_GAGNA;
            R401_ES_SKRANING = _R401_ES_SKRANING;
            N401_ES_INNSKATTSKVOD = _N401_ES_INNSKATTSKVOD;
            A401_ES_INNSKATTSKVOD = _A401_ES_INNSKATTSKVOD;
            N401_ES_STADA_INNSKATTSKVOD = _N401_ES_STADA_INNSKATTSKVOD;
            K401_ES_FASTANUMER_EIGNAR = _K401_ES_FASTANUMER_EIGNAR;
            K401_ES_SKRANINGARNR = _K401_ES_SKRANINGARNR;
            C401_ES_EKKI_I_NOTKUN = _C401_ES_EKKI_I_NOTKUN;
            C401_ES_VISTVAENT_OKUTAEKI = _C401_ES_VISTVAENT_OKUTAEKI;
            C401_ES_VISTVAENT_ANNAD = _C401_ES_VISTVAENT_ANNAD;
            N401_ES_VISTV_FYRNINGARALAG = _N401_ES_VISTV_FYRNINGARALAG;
            N401_ES_VSK_NUMER = _N401_ES_VSK_NUMER;
        }
    }

    public class RSK0401_01ViewModel : ViewModelBase
    {

        private BindingList<RSK401_EIGNASKRA_ITEM> _RSK401_EIGNASKRA;

        public BindingList<RSK401_EIGNASKRA_ITEM> RSK401_EIGNASKRA
        {
            get
            {
                return _RSK401_EIGNASKRA;
            }
            set
            {
                _RSK401_EIGNASKRA = value;
                OnPropertyChanged();
            }
        }

        public RSK0401_01ViewModel()
        {
            
        }
    }
}