using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{

    public struct RSK304_AL_COMMENT_ITEM
    {
        public string KENNITALA { get; set; }
        public string TEKJUAR { get; set; }
        public int BLADANR { get; set; }
        public int NR_FRAMTAL { get; set; }
        public int LINUNR { get; set; }
        public string K304_AL_KT_GREIDANDI { get; set; }
        public string T304_AL_LAUNAGREIDANDI { get; set; }
        public int N304_AL_FJARHAED { get; set; }
        public int N304_AL_VEGALENGD { get; set; }
        public string RSK_AL_UPPRUNI { get; set; }
        public RSK304_AL_COMMENT_ITEM(string _KENNITALA, string _TEKJUAR, int _BLADANR, int _NR_FRAMTAL, int _LINUNR,
            string _K304_AL_KT_GREIDANDI, string _T304_AL_LAUNAGREIDANDI, int _N304_AL_FJARHAED, int _N304_AL_VEGALENGD, string _RSK_AL_UPPRUNI)
        {
            KENNITALA = _KENNITALA;
            TEKJUAR = _TEKJUAR;
            BLADANR = _BLADANR;
            NR_FRAMTAL = _NR_FRAMTAL;
            LINUNR = _LINUNR;
            K304_AL_KT_GREIDANDI = _K304_AL_KT_GREIDANDI;
            T304_AL_LAUNAGREIDANDI = _T304_AL_LAUNAGREIDANDI;
            N304_AL_FJARHAED = _N304_AL_FJARHAED;
            N304_AL_VEGALENGD = _N304_AL_VEGALENGD;
            RSK_AL_UPPRUNI = _RSK_AL_UPPRUNI;
        }
    }

    public class RSK0304_01ViewModel : ViewModelBase
    {

        private BindingList<RSK304_AL_COMMENT_ITEM> _RSK304_AL_COMMENT;




        public BindingList<RSK304_AL_COMMENT_ITEM> RSK304_AL_COMMENT
        {
            get
            {
                return _RSK304_AL_COMMENT;
            }
            set
            {
                _RSK304_AL_COMMENT = value;
                OnPropertyChanged();
            }
        }


        public RSK0304_01ViewModel()
        {
            
        }
    }
}