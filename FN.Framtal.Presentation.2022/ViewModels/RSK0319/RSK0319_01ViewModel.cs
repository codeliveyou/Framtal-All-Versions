using System.ComponentModel;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public struct RSK0319_ALMMEN_ITEM
    {
        public string RSK0319_ALMMEN_A { get; set; }
        public string RSK0319_ALMMEN_B { get; set; }
        public string RSK0319_ALMMEN_C { get; set; }
        public string RSK0319_ALMMEN_D { get; set; }
        public string RSK0319_ALMMEN_E { get; set; }
        public string RSK0319_ALMMEN_F { get; set; }
        public string RSK0319_ALMMEN_G { get; set; }
        public string RSK0319_ALMMEN_H { get; set; }
        public string RSK0319_ALMMEN_I { get; set; }
        public string RSK0319_ALMMEN_J { get; set; }
        public string RSK0319_ALMMEN_K { get; set; }
        public string RSK0319_ALMMEN_L { get; set; }
        public string RSK0319_ALMMEN_M { get; set; }
        public string RSK0319_ALMMEN_N { get; set; }
        public string RSK0319_ALMMEN_O { get; set; }
        public string RSK0319_ALMMEN_P { get; set; }
        public string RSK0319_ALMMEN_Q { get; set; }

        public RSK0319_ALMMEN_ITEM(
            string _RSK0319_ALMMEN_A,
            string _RSK0319_ALMMEN_B,
            string _RSK0319_ALMMEN_C,
            string _RSK0319_ALMMEN_D,
            string _RSK0319_ALMMEN_E,
            string _RSK0319_ALMMEN_F,
            string _RSK0319_ALMMEN_G,
            string _RSK0319_ALMMEN_H,
            string _RSK0319_ALMMEN_I,
            string _RSK0319_ALMMEN_J,
            string _RSK0319_ALMMEN_K,
            string _RSK0319_ALMMEN_L,
            string _RSK0319_ALMMEN_M,
            string _RSK0319_ALMMEN_N,
            string _RSK0319_ALMMEN_O,
            string _RSK0319_ALMMEN_P,
            string _RSK0319_ALMMEN_Q
            )
        {
            RSK0319_ALMMEN_A = _RSK0319_ALMMEN_A;
            RSK0319_ALMMEN_B = _RSK0319_ALMMEN_B;
            RSK0319_ALMMEN_C = _RSK0319_ALMMEN_C;
            RSK0319_ALMMEN_D = _RSK0319_ALMMEN_D;
            RSK0319_ALMMEN_E = _RSK0319_ALMMEN_E;
            RSK0319_ALMMEN_F = _RSK0319_ALMMEN_F;
            RSK0319_ALMMEN_G = _RSK0319_ALMMEN_G;
            RSK0319_ALMMEN_H = _RSK0319_ALMMEN_H;
            RSK0319_ALMMEN_I = _RSK0319_ALMMEN_I;
            RSK0319_ALMMEN_J = _RSK0319_ALMMEN_J;
            RSK0319_ALMMEN_K = _RSK0319_ALMMEN_K;
            RSK0319_ALMMEN_L = _RSK0319_ALMMEN_L;
            RSK0319_ALMMEN_M = _RSK0319_ALMMEN_M;
            RSK0319_ALMMEN_N = _RSK0319_ALMMEN_N;
            RSK0319_ALMMEN_O = _RSK0319_ALMMEN_O;
            RSK0319_ALMMEN_P = _RSK0319_ALMMEN_P;
            RSK0319_ALMMEN_Q = _RSK0319_ALMMEN_Q;
        }
    }
    public class RSK0319_01ViewModel : ViewModelBase
    {
        BindingList<RSK0319_ALMMEN_ITEM> _RSK0319_ALMMEN;
        public BindingList<RSK0319_ALMMEN_ITEM> RSK0319_ALMMEN
        {
            get { return _RSK0319_ALMMEN; }
            set
            {
                _RSK0319_ALMMEN = value;
                OnPropertyChanged();
            }
        }
        public RSK0319_01ViewModel() {
            RSK0319_ALMMEN = new BindingList<RSK0319_ALMMEN_ITEM>()
            {
                new RSK0319_ALMMEN_ITEM(),
                new RSK0319_ALMMEN_ITEM(),
                new RSK0319_ALMMEN_ITEM(),
            };
        }
    }
}