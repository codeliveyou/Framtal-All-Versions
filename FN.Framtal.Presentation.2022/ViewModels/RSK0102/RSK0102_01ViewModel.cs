using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{

    public struct RSK102_BARN_LAUNATEKJUR_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K102_BL_KT_GREIDANDI { get; set; }
        public string T102_BL_GREIDANDI { get; set; }
        public int N102_BL_GREIDSLA { get; set; }
        public string RSK_BL_UPPRUNI { get; set; }
        public RSK102_BARN_LAUNATEKJUR_ITEM(string _KENNITALA, string _TEKJUAR, int _NR_FRAMTAL, int _LINUNR,
            string _K102_BL_KT_GREIDANDI, string _T102_BL_GREIDANDI, int _N102_BL_GREIDSLA, string _RSK_BL_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K102_BL_KT_GREIDANDI = _K102_BL_KT_GREIDANDI;
            T102_BL_GREIDANDI = _T102_BL_GREIDANDI;
            N102_BL_GREIDSLA = _N102_BL_GREIDSLA;
            RSK_BL_UPPRUNI = _RSK_BL_UPPRUNI;
        }
    }

    public class RSK0102_01ViewModel : ViewModelBase
    {

        private BindingList<RSK102_BARN_LAUNATEKJUR_ITEM> _RSK102_BARN_LAUNATEKJUR;



        public BindingList<RSK102_BARN_LAUNATEKJUR_ITEM> RSK102_BARN_LAUNATEKJUR
        {
            get
            {
                return _RSK102_BARN_LAUNATEKJUR;
            }
            set
            {
                _RSK102_BARN_LAUNATEKJUR = value;
                OnPropertyChanged();
            }
        }



        public RSK0102_01ViewModel()
        {
            
        }
    }
}