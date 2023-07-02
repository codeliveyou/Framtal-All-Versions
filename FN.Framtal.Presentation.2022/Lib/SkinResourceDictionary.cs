using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FN.Framtal.Presentation._2022.Lib
{
    public class SkinResourceDictionary : ResourceDictionary
    {
        private Uri _redSource;
        private Uri _blueSource;
        private Uri _greenSource;
        private Uri _yellowSource;

        public Uri RedSource { get => _redSource; set { _redSource = value; UpdateSource(); } }
        public Uri BlueSource { get => _blueSource; set { _blueSource = value; UpdateSource(); } }
        public Uri GreenSource { get => _greenSource; set { _greenSource = value; UpdateSource(); } }
        public Uri YellowSource { get => _yellowSource; set { _yellowSource = value; UpdateSource(); } }

        private void UpdateSource()
        {
            Uri val;
            switch (App.Skin)
            {
                case Skin.Red:
                    val = _redSource;
                    break;
                case Skin.Green:
                    val = _greenSource;
                    break;
                case Skin.Yellow:
                    val = _yellowSource;
                    break;
                default:
                    val = _blueSource;
                    break;
            }
            if (val != null && base.Source != val)
                base.Source = val;
        }
    }
}
