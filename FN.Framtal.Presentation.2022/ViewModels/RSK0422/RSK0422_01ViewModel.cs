using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{

    public struct RSK422_SAMSTARFSV_EIGENDUR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int BLADANR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string T422_SE_EIGANDI { get; set; }
        public string K422_SE_KT_EIGANDA { get; set; }
        public string R422_SE_LAND { get; set; }
        public string R422_SE_STAERD_FYRIRTAEKIS { get; set; }
        public int N422_SE_EIGNARHLUTI { get; set; }
        public RSK422_SAMSTARFSV_EIGENDUR_ITEM(
            string _KENNITALA,
            string _TEKJUAR,
            int _BLADANR,
            int _NR_FRAMTAL,
            int _LINUNR,
            string _T422_SE_EIGANDI,
            string _K422_SE_KT_EIGANDA,
            string _R422_SE_LAND,
            string _R422_SE_STAERD_FYRIRTAEKIS,
            int _N422_SE_EIGNARHLUTI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            BLADANR = _BLADANR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            T422_SE_EIGANDI = _T422_SE_EIGANDI;
            K422_SE_KT_EIGANDA = _K422_SE_KT_EIGANDA;
            R422_SE_LAND = _R422_SE_LAND;
            R422_SE_STAERD_FYRIRTAEKIS = _R422_SE_STAERD_FYRIRTAEKIS;
            N422_SE_EIGNARHLUTI = _N422_SE_EIGNARHLUTI;
        }
    }



    public class RSK0422_01ViewModel : ViewModelBase
    {
        private BindingList<RSK422_SAMSTARFSV_EIGENDUR_ITEM> _RSK422_SAMSTARFSV_EIGENDUR;


        public BindingList<RSK422_SAMSTARFSV_EIGENDUR_ITEM> RSK422_SAMSTARFSV_EIGENDUR
        {
            get
            {
                return _RSK422_SAMSTARFSV_EIGENDUR;
            }
            set
            {
                _RSK422_SAMSTARFSV_EIGENDUR = value;
                OnPropertyChanged();
            }
        }



        public RSK0422_01ViewModel()
        {

        }
    }
}
