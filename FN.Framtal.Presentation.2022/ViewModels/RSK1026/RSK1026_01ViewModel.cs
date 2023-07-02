using System;
using System.Windows;

namespace FN.Framtal.Presentation._2022.ViewModels
{
    public class RSK1026_01ViewModel : ViewModelBase
    {
        string _AA = "0";
        string _A = "0";
        string _B = "0";
        string _BB = "0";
        string _C = "0";
        string _D = "0";
        string _E = "0";
        string _F = "0";
        string _G = "0";
        string _J = "0";
        string _K = "0";
        string _L = "0";
        string _M = "0";
        public string AA
        {
            get
            {
                try
                {
                    double res = double.Parse(A01);
                    res += double.Parse(A02);
                    res += double.Parse(A03);
                    res += double.Parse(A04);
                    res += double.Parse(A05);
                    res += double.Parse(A06);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string A
        {
            get
            {
                try
                {
                    double res = double.Parse(A1);
                    res += double.Parse(A2);
                    res += double.Parse(A3);
                    res += double.Parse(A4);
                    res += double.Parse(A5);
                    res += double.Parse(A6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string BB
        {
            get
            {
                try
                {
                    double res = double.Parse(B11);
                    res += double.Parse(B12);
                    res += double.Parse(B13);
                    res += double.Parse(B14);
                    res += double.Parse(B15);
                    res += double.Parse(B16);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string B
        {
            get
            {
                try
                {
                    double res = double.Parse(B1);
                    res += double.Parse(B2);
                    res += double.Parse(B3);
                    res += double.Parse(B4);
                    res += double.Parse(B5);
                    res += double.Parse(B6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string C
        {
            get
            {
                try
                {
                    double res = double.Parse(C1);
                    res += double.Parse(C2);
                    res += double.Parse(C3);
                    res += double.Parse(C4);
                    res += double.Parse(C5);
                    res += double.Parse(C6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string D
        {
            get
            {
                try
                {
                    double res = double.Parse(D1);
                    res += double.Parse(D2);
                    res += double.Parse(D3);
                    res += double.Parse(D4);
                    res += double.Parse(D5);
                    res += double.Parse(D6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string E
        {
            get
            {
                try
                {
                    double res = double.Parse(E1);
                    res += double.Parse(E2);
                    res += double.Parse(E3);
                    res += double.Parse(E4);
                    res += double.Parse(E5);
                    res += double.Parse(E6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string G
        {
            get
            {
                try
                {
                    double res = double.Parse(G1);
                    res += double.Parse(G2);
                    res += double.Parse(G3);
                    res += double.Parse(G4);
                    res += double.Parse(G5);
                    res += double.Parse(G6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string J
        {
            get
            {
                try
                {
                    double res = double.Parse(H1);
                    res += double.Parse(H2);
                    res += double.Parse(H3);
                    res += double.Parse(H4);
                    res += double.Parse(H5);
                    res += double.Parse(H6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string K
        {
            get
            {
                try
                {
                    double res = double.Parse(D1);
                    res += double.Parse(D2);
                    res += double.Parse(D3);
                    res += double.Parse(D4);
                    res += double.Parse(D5);
                    res += double.Parse(D6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string L
        {
            get
            {
                try
                {
                    double res = double.Parse(E1);
                    res += double.Parse(E2);
                    res += double.Parse(E3);
                    res += double.Parse(E4);
                    res += double.Parse(E5);
                    res += double.Parse(E6);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string M
        {
            get
            {
                try
                {
                    double res = double.Parse(J);
                    res += double.Parse(K);
                    res += double.Parse(L);
                    return Math.Round(res).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }






        string _A01 = "0";
        string _A1 = "0";
        string _B1 = "0";
        string _C1 = "0";
        string _D1 = "0";
        string _E1 = "0";
        string _G1 = "0";
        string _B11 = "0";
        public string A1
        {
            get
            {
                return _A1;
            }
            set
            {
                _A1 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D1));
                OnPropertyChanged(nameof(F1));
                OnPropertyChanged(nameof(H1));
                OnPropertyChanged(nameof(I1));
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus1));
            }
        }
        public string A01
        {
            get
            {
                return _A01;
            }
            set
            {
                _A01 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D1));
                OnPropertyChanged(nameof(F1));
                OnPropertyChanged(nameof(H1));
                OnPropertyChanged(nameof(I1));
                OnPropertyChanged(nameof(AA));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus1));
            }
        }

        public string B11
        {
            get { return _B11; }
            set
            {
                _B11 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D1));
                OnPropertyChanged(nameof(F1));
                OnPropertyChanged(nameof(H1));
                OnPropertyChanged(nameof(I1));
                OnPropertyChanged(nameof(BB));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus1));
            }
        }

        public string B1
        {
            get { return _B1; }
            set
            {
                _B1 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D1));
                OnPropertyChanged(nameof(F1));
                OnPropertyChanged(nameof(H1));
                OnPropertyChanged(nameof(I1));
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus1));
            }
        }

        public string C1
        {
            get { return _C1; }
            set
            {
                _C1 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(C));
            }
        }

        public string D1
        {
            set
            {
                _D1 = value;
            }
            get
            {
                try
                {
                    _D1 = Math.Round(double.Parse(A01) * 0.24 + double.Parse(A1) * 0.255 + double.Parse(B11) * 0.11 + double.Parse(B1) * 0.07).ToString();
                }
                catch (Exception)
                {
                    _D1 = "0";
                }
                return _D1;
            }
        }

        public string E1
        {
            get { return _E1; }
            set
            {
                _E1 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(F1));
                OnPropertyChanged(nameof(I1));
                OnPropertyChanged(nameof(L));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(E));
                OnPropertyChanged(nameof(PositiveStatus1));
            }
        }

        public string F1
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(D1) - double.Parse(E1)).ToString();
                }
                catch (Exception)
                { return "0"; }
            }
        }

        public string G1
        {
            get { return _G1; }
            set
            {
                _G1 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(I1));
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(PositiveStatus1));
            }
        }

        string _H1;
        public string H1
        {
            set
            {
                _H1 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
            }
            get
            {
                try
                {
                    _H1 = Math.Round(double.Parse(A01) * 0.024 + double.Parse(A1) * 0.0255 + double.Parse(B11) * 0.011 + double.Parse(B1) * 0.007).ToString();
                }
                catch (Exception)
                {
                    _H1 = "0";
                }
                return _H1;
            }
        }
        public string I1
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A01) * 0.24 + double.Parse(A1) * 0.255 + double.Parse(B11) * 0.11 + double.Parse(B1) * 0.07 - double.Parse(E1) - double.Parse(G1)).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string PositiveStatus1
        {
            get
            {
                try
                {
                    return double.Parse(F1) < 0 ? "Inneign" : "Til greiðslu";
                }
                catch (Exception)
                {

                }
                return "Til greiðslu";
            }
        }





        string _A02 = "0";
        string _A2 = "0";
        string _B2 = "0";
        string _C2 = "0";
        string _D2 = "0";
        string _E2 = "0";
        string _G2 = "0";
        string _B12 = "0";
        public string A2
        {
            get
            {
                return _A2;
            }
            set
            {
                _A2 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D2));
                OnPropertyChanged(nameof(F2));
                OnPropertyChanged(nameof(H2));
                OnPropertyChanged(nameof(I2));
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus2));
            }
        }
        public string A02
        {
            get
            {
                return _A02;
            }
            set
            {
                _A02 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D2));
                OnPropertyChanged(nameof(F2));
                OnPropertyChanged(nameof(H2));
                OnPropertyChanged(nameof(I2));
                OnPropertyChanged(nameof(AA));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus2));
            }
        }

        public string B12
        {
            get { return _B12; }
            set
            {
                _B12 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D2));
                OnPropertyChanged(nameof(F2));
                OnPropertyChanged(nameof(H2));
                OnPropertyChanged(nameof(I2));
                OnPropertyChanged(nameof(BB));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus2));
            }
        }

        public string B2
        {
            get { return _B2; }
            set
            {
                _B2 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D2));
                OnPropertyChanged(nameof(F2));
                OnPropertyChanged(nameof(H2));
                OnPropertyChanged(nameof(I2));
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus2));
            }
        }

        public string C2
        {
            get { return _C2; }
            set
            {
                _C2 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(C));
            }
        }

        public string D2
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A02) * 0.24 + double.Parse(A2) * 0.255 + double.Parse(B12) * 0.11 + double.Parse(B2) * 0.07).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string E2
        {
            get { return _E2; }
            set
            {
                _E2 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(F2));
                OnPropertyChanged(nameof(I2));
                OnPropertyChanged(nameof(L));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(E));
                OnPropertyChanged(nameof(PositiveStatus2));
            }
        }

        public string F2
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(D2) - double.Parse(E2)).ToString();
                }
                catch (Exception)
                { return "0"; }
            }
        }

        public string G2
        {
            get { return _G2; }
            set
            {
                _G2 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(I2));
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(PositiveStatus2));
            }
        }

        public string H2
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A02) * 0.024 + double.Parse(A2) * 0.0255 + double.Parse(B12) * 0.011 + double.Parse(B2) * 0.007).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string I2
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A02) * 0.24 + double.Parse(A2) * 0.255 + double.Parse(B12) * 0.11 + double.Parse(B2) * 0.07 - double.Parse(E2) - double.Parse(G2)).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string PositiveStatus2
        {
            get
            {
                try
                {
                    return double.Parse(F2) < 0 ? "Inneign" : "Til greiðslu";
                }
                catch (Exception)
                {

                }
                return "Til greiðslu";
            }
        }






        string _A03 = "0";
        string _A3 = "0";
        string _B3 = "0";
        string _C3 = "0";
        string _D3 = "0";
        string _E3 = "0";
        string _G3 = "0";
        string _B13 = "0";
        public string A3
        {
            get
            {
                return _A3;
            }
            set
            {
                _A3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D3));
                OnPropertyChanged(nameof(F3));
                OnPropertyChanged(nameof(H3));
                OnPropertyChanged(nameof(I3));
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus3));
            }
        }
        public string A03
        {
            get
            {
                return _A03;
            }
            set
            {
                _A03 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D3));
                OnPropertyChanged(nameof(F3));
                OnPropertyChanged(nameof(H3));
                OnPropertyChanged(nameof(I3));
                OnPropertyChanged(nameof(AA));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus3));
            }
        }

        public string B13
        {
            get { return _B13; }
            set
            {
                _B13 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D3));
                OnPropertyChanged(nameof(F3));
                OnPropertyChanged(nameof(H3));
                OnPropertyChanged(nameof(I3));
                OnPropertyChanged(nameof(BB));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus3));
            }
        }

        public string B3
        {
            get { return _B3; }
            set
            {
                _B3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D3));
                OnPropertyChanged(nameof(F3));
                OnPropertyChanged(nameof(H3));
                OnPropertyChanged(nameof(I3));
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus3));
            }
        }

        public string C3
        {
            get { return _C3; }
            set
            {
                _C3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(C));
            }
        }

        public string D3
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A03) * 0.24 + double.Parse(A3) * 0.255 + double.Parse(B13) * 0.11 + double.Parse(B3) * 0.07).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string E3
        {
            get { return _E3; }
            set
            {
                _E3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(F3));
                OnPropertyChanged(nameof(I3));
                OnPropertyChanged(nameof(L));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(E));
                OnPropertyChanged(nameof(PositiveStatus3));
            }
        }

        public string F3
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(D3) - double.Parse(E3)).ToString();
                }
                catch (Exception)
                { return "0"; }
            }
        }

        public string G3
        {
            get { return _G3; }
            set
            {
                _G3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(I3));
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(PositiveStatus3));
            }
        }

        public string H3
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A03) * 0.024 + double.Parse(A3) * 0.0255 + double.Parse(B13) * 0.011 + double.Parse(B3) * 0.007).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string I3
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A03) * 0.24 + double.Parse(A3) * 0.255 + double.Parse(B13) * 0.11 + double.Parse(B3) * 0.07 - double.Parse(E3) - double.Parse(G3)).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string PositiveStatus3
        {
            get
            {
                try
                {
                    return double.Parse(F3) < 0 ? "Inneign" : "Til greiðslu";
                }
                catch (Exception)
                {

                }
                return "Til greiðslu";
            }
        }









        string _A04 = "0";
        string _A4 = "0";
        string _B4 = "0";
        string _C4 = "0";
        string _D4 = "0";
        string _E4 = "0";
        string _G4 = "0";
        string _B14 = "0";
        public string A4
        {
            get
            {
                return _A4;
            }
            set
            {
                _A4 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D4));
                OnPropertyChanged(nameof(F4));
                OnPropertyChanged(nameof(H4));
                OnPropertyChanged(nameof(I4));
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }
        public string A04
        {
            get
            {
                return _A04;
            }
            set
            {
                _A04 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D4));
                OnPropertyChanged(nameof(F4));
                OnPropertyChanged(nameof(H4));
                OnPropertyChanged(nameof(I4));
                OnPropertyChanged(nameof(AA));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string B14
        {
            get { return _B14; }
            set
            {
                _B14 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D4));
                OnPropertyChanged(nameof(F4));
                OnPropertyChanged(nameof(H4));
                OnPropertyChanged(nameof(I4));
                OnPropertyChanged(nameof(BB));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string B4
        {
            get { return _B4; }
            set
            {
                _B4 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D4));
                OnPropertyChanged(nameof(F4));
                OnPropertyChanged(nameof(H4));
                OnPropertyChanged(nameof(I4));
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string C4
        {
            get { return _C4; }
            set
            {
                _C4 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(C));
            }
        }

        public string D4
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A04) * 0.24 + double.Parse(A4) * 0.255 + double.Parse(B14) * 0.11 + double.Parse(B4) * 0.07).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string E4
        {
            get { return _E4; }
            set
            {
                _E4 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(F4));
                OnPropertyChanged(nameof(I4));
                OnPropertyChanged(nameof(L));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(E));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string F4
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(D4) - double.Parse(E4)).ToString();
                }
                catch (Exception)
                { return "0"; }
            }
        }

        public string G4
        {
            get { return _G4; }
            set
            {
                _G4 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(I4));
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string H4
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A04) * 0.024 + double.Parse(A4) * 0.0255 + double.Parse(B14) * 0.011 + double.Parse(B4) * 0.007).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string I4
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A04) * 0.24 + double.Parse(A4) * 0.255 + double.Parse(B14) * 0.11 + double.Parse(B4) * 0.07 - double.Parse(E4) - double.Parse(G4)).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string PositiveStatus4
        {
            get
            {
                try
                {
                    return double.Parse(F4) < 0 ? "Inneign" : "Til greiðslu";
                }
                catch (Exception)
                {

                }
                return "Til greiðslu";
            }
        }










        string _A05 = "0";
        string _A5 = "0";
        string _B5 = "0";
        string _C5 = "0";
        string _D5 = "0";
        string _E5 = "0";
        string _G5 = "0";
        string _B15 = "0";
        public string A5
        {
            get
            {
                return _A5;
            }
            set
            {
                _A5 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D5));
                OnPropertyChanged(nameof(F5));
                OnPropertyChanged(nameof(H5));
                OnPropertyChanged(nameof(I5));
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }
        public string A05
        {
            get
            {
                return _A05;
            }
            set
            {
                _A05 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D5));
                OnPropertyChanged(nameof(F5));
                OnPropertyChanged(nameof(H5));
                OnPropertyChanged(nameof(I5));
                OnPropertyChanged(nameof(AA));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string B15
        {
            get { return _B15; }
            set
            {
                _B15 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D5));
                OnPropertyChanged(nameof(F5));
                OnPropertyChanged(nameof(H5));
                OnPropertyChanged(nameof(I5));
                OnPropertyChanged(nameof(BB));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string B5
        {
            get { return _B5; }
            set
            {
                _B5 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D5));
                OnPropertyChanged(nameof(F5));
                OnPropertyChanged(nameof(H5));
                OnPropertyChanged(nameof(I5));
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string C5
        {
            get { return _C5; }
            set
            {
                _C5 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(C));
            }
        }

        public string D5
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A05) * 0.24 + double.Parse(A5) * 0.255 + double.Parse(B15) * 0.11 + double.Parse(B5) * 0.07).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string E5
        {
            get { return _E5; }
            set
            {
                _E5 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(F5));
                OnPropertyChanged(nameof(I5));
                OnPropertyChanged(nameof(L));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(E));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string F5
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(D5) - double.Parse(E5)).ToString();
                }
                catch (Exception)
                { return "0"; }
            }
        }

        public string G5
        {
            get { return _G5; }
            set
            {
                _G5 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(I5));
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string H5
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A05) * 0.024 + double.Parse(A5) * 0.0255 + double.Parse(B15) * 0.011 + double.Parse(B5) * 0.007).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string I5
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A05) * 0.24 + double.Parse(A5) * 0.255 + double.Parse(B15) * 0.11 + double.Parse(B5) * 0.07 - double.Parse(E5) - double.Parse(G5)).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string PositiveStatus5
        {
            get
            {
                try
                {
                    return double.Parse(F5) < 0 ? "Inneign" : "Til greiðslu";
                }
                catch (Exception)
                {

                }
                return "Til greiðslu";
            }
        }









        string _A06 = "0";
        string _A6 = "0";
        string _B6 = "0";
        string _C6 = "0";
        string _D6 = "0";
        string _E6 = "0";
        string _G6 = "0";
        string _B16 = "0";
        public string A6
        {
            get
            {
                return _A6;
            }
            set
            {
                _A6 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D6));
                OnPropertyChanged(nameof(F6));
                OnPropertyChanged(nameof(H6));
                OnPropertyChanged(nameof(I6));
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }
        public string A06
        {
            get
            {
                return _A06;
            }
            set
            {
                _A06 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D6));
                OnPropertyChanged(nameof(F6));
                OnPropertyChanged(nameof(H6));
                OnPropertyChanged(nameof(I6));
                OnPropertyChanged(nameof(AA));
                OnPropertyChanged(nameof(J));
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string B16
        {
            get { return _B16; }
            set
            {
                _B16 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D6));
                OnPropertyChanged(nameof(F6));
                OnPropertyChanged(nameof(H6));
                OnPropertyChanged(nameof(I6));
                OnPropertyChanged(nameof(BB));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string B6
        {
            get { return _B6; }
            set
            {
                _B6 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(D6));
                OnPropertyChanged(nameof(F6));
                OnPropertyChanged(nameof(H6));
                OnPropertyChanged(nameof(I6));
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(J)); 
                OnPropertyChanged(nameof(K));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(D));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string C6
        {
            get { return _C6; }
            set
            {
                _C6 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(C));
            }
        }

        public string D6
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A06) * 0.24 + double.Parse(A6) * 0.255 + double.Parse(B16) * 0.11 + double.Parse(B6) * 0.07).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string E6
        {
            get { return _E6; }
            set
            {
                _E6 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(F6));
                OnPropertyChanged(nameof(I6));
                OnPropertyChanged(nameof(L));
                OnPropertyChanged(nameof(M));
                OnPropertyChanged(nameof(E));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string F6
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(D6) - double.Parse(E6)).ToString();
                }
                catch (Exception)
                { return "0"; }
            }
        }

        public string G6
        {
            get { return _G6; }
            set
            {
                _G6 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(I6));
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(PositiveStatus4));
            }
        }

        public string H6
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A06) * 0.024 + double.Parse(A6) * 0.0255 + double.Parse(B16) * 0.011 + double.Parse(B6) * 0.007).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }
        public string I6
        {
            get
            {
                try
                {
                    return Math.Round(double.Parse(A06) * 0.24 + double.Parse(A6) * 0.255 + double.Parse(B16) * 0.11 + double.Parse(B6) * 0.07 - double.Parse(E6) - double.Parse(G6)).ToString();
                }
                catch (Exception)
                {
                    return "0";
                }
            }
        }

        public string PositiveStatus6
        {
            get
            {
                try
                {
                    return double.Parse(F6) < 0 ? "Inneign" : "Til greiðslu";
                }
                catch (Exception)
                {

                }
                return "Til greiðslu";
            }
        }



    }
}