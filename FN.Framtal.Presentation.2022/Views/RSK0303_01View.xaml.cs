using FN.Framtal.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FN.Framtal.Presentation._2022.Views
{
    /// <summary>
    /// Interaction logic for RSK0303_01View.xaml
    /// </summary>
    public partial class RSK0303_01View : UserControl
    {
        public RSK0303_01View()
        {
            InitializeComponent();

            // create and add 7 lines of empty data to dgData
            for (int i = 0; i < 7; i++)
            { dgData.Items.Add(new DataItem()); }
        }

        private void cbOwners_CheckedChange(object sender, RoutedEventArgs e)
        {
            List<CheckBoxWithoutBorder> chkBoxes = new List<CheckBoxWithoutBorder>() { cbOneOwner, cbManyOwners };
            CheckBoxWithoutBorder chk = (CheckBoxWithoutBorder)sender;
            foreach (var chkBox in chkBoxes)
            {
                if (chk.Name != chkBox.Name)
                { chkBox.CheckBox.IsChecked = false; }
            }
        }

        private void cbTypes_CheckedChange(object sender, RoutedEventArgs e)
        {
            List<CheckBoxWithoutBorder> chkBoxes = new List<CheckBoxWithoutBorder>() { cbApartmentBuildings, cbTownhouse, cbVillas, cbCommercialRealEstate };
            CheckBoxWithoutBorder chk = (CheckBoxWithoutBorder)sender;
            foreach (var chkBox in chkBoxes)
            {
                if (chk.Name != chkBox.Name)
                { chkBox.CheckBox.IsChecked = false; }
            }
        }

        private void tbSetbExtraWorkTotal1_TextChanged(object sender, RoutedEventArgs e)
        {
            float hours = textToNumber(N303_D_AUKAVINNA_KLST1.TextBox.Text);
            float rate = textToNumber(N303_D_AUKAVINNA_TAXTI1.TextBox.Text);
            float total = hours * rate;
            N303_SAMTALS_FLUTT_A_101.TextBox.Text = numberToText(total);
        }

        private void tbSetbExtraWorkTotal2_TextChanged(object sender, RoutedEventArgs e)
        {
            float hours = textToNumber(N303_D_AUKAVINNA_KLST2.TextBox.Text);
            float rate = textToNumber(N303_D_AUKAVINNA_TAXTI2.TextBox.Text);
            float total = hours * rate;
            N303_SAMTALS_FLUTT_A_101.TextBox.Text = numberToText(total);
        }

        private void tbSetbOtherWorkTotal1_TextChanged(object sender, RoutedEventArgs e)
        {
            float hours = textToNumber(N303_E_ONNUR_EIGIN_VINNA_KLST1.TextBox.Text);
            float rate = textToNumber(N303_E_ONNUR_EIGIN_VINNA_TXTI1.TextBox.Text);
            float total = hours * rate;
            N303_SAMTALS_FLUTT_A_101.TextBox.Text = numberToText(total);
        }

        private void tbSetbOtherWorkTotal2_TextChanged(object sender, RoutedEventArgs e)
        {
            float hours = textToNumber(N303_E_ONNUR_EIGIN_VINNA_KLST2.TextBox.Text);
            float rate = textToNumber(N303_E_ONNUR_EIGIN_VINNA_TXTI2.TextBox.Text);
            float total = hours * rate;
            N303_SAMTALS_FLUTT_A_101.TextBox.Text = numberToText(total);
        }
        private void tbSetAtoETotal_TextChanged(object sender, RoutedEventArgs e)
        {
            float decATotal1 = textToNumber(N303_A_TRESMIDI.TextBox.Text);
            float decATotal2 = textToNumber(N303_A_MURVERK.TextBox.Text);
            float decATotal3 = textToNumber(N303_A_PIPULAGNIR.TextBox.Text);
            float decATotal4 = textToNumber(N303_A_RAFLAGNIR.TextBox.Text);
            float decATotal5 = textToNumber(N303_A_MALUN.TextBox.Text);
            float decATotal6 = textToNumber(N303_A_TEIKNINGAR.TextBox.Text);
            float decATotal7 = textToNumber(T303_A_ANNAD_SKYRING.TextBox.Text);
            float decATotal = decATotal1 + decATotal2 + decATotal3 + decATotal4 + decATotal5 + decATotal6 + decATotal7;

            float decBTotal = textToNumber(N303_B_KEYPT_BYGGEFNI_SAMT.TextBox.Text);

            float decCTotal1 = textToNumber(T303_C_ANNAR_BYGGKOSTN1.TextBox.Text);
            float decCTotal2 = textToNumber(N303_C_ANNAR_BYGGKOSTN1.TextBox.Text);
            float decCTotal = decCTotal1 + decCTotal2;

            float decDTotal1 = textToNumber(N303_D_AUKAVINNA_KLST1.TextBox.Text);
            float decDTotal2 = textToNumber(N303_D_AUKAVINNA_TAXTI1.TextBox.Text);
            float decDTotal = decDTotal1 + decDTotal2;

            float decETotal1 = textToNumber(N303_D_AUKAVINNA_KLST1.TextBox.Text);
            float decETotal2 = textToNumber(N303_D_AUKAVINNA_TAXTI2.TextBox.Text);
            float decETotal = decETotal1 + decETotal2;

            float decAtoETotal = decATotal + decBTotal + decCTotal + decDTotal + decETotal;
            N303_SAMTALS_FLUTT_A_101.TextBox.Text = numberToText(decAtoETotal);
        }

        private void tbSetJTotal_TextChanged(object sender, RoutedEventArgs e)
        {
            float decFTotal = textToNumber(N303_KAUPV_HUS_I_SMIDUM.TextBox.Text);

            float decGTotal = textToNumber(N303_HLUTD_SAMEIG_BYGGKOSTN.TextBox.Text);

            float decHTotal = textToNumber(N303_SERKOSTN_EIGANDA.TextBox.Text);

            float decITotal = textToNumber(N303_ENDURGR_VSK.TextBox.Text);

            float decJTotal = decFTotal + decGTotal + decHTotal - decITotal;
            N303_SAMTALS_FLUTT_A_101.TextBox.Text = numberToText(decJTotal);
        }

        private void tbSetJtoLTotal_TextChanged(object sender, RoutedEventArgs e)
        {
            float decJTotal = textToNumber(N303_KOSTNADUR_ALLS_A_ARINU.TextBox.Text);

            float decKTotal = textToNumber(N303_HEILDARKOSTN_F_FYRRA_ARI.TextBox.Text);

            float decLTotal = textToNumber(N303_SOLUHAGN1.TextBox.Text);

            float decJtoLTotal = decJTotal + decKTotal - decLTotal;
            N303_SAMTALS_FLUTT_A_101.TextBox.Text = numberToText(decJtoLTotal);
        }

        private void tbSetTotalInItem4_1_TextChanged(object sender, RoutedEventArgs e)
        {
            float decRealEstateAppraisal = textToNumber(N303_FASTEIGNAMAT.TextBox.Text);

            float decUnestimatedConstructionCosts = textToNumber(N303_OMETIN_BYGGINGARKOSTN.TextBox.Text);

            float decTotalInItem4_1 = decRealEstateAppraisal + decUnestimatedConstructionCosts;
            N303_SAMTALS_SUND_KOSTN_ARS_2.TextBox.Text = numberToText(decTotalInItem4_1);
        }

        private void dgData_tbConstructionCosts_TextChanged(object sender, RoutedEventArgs e)
        {
            float decTotal = 0;
            foreach (DataItem item in dgData.Items)
            { decTotal += textToNumber(item.ConstructionCosts); }
            N303_FASTEIGNAMAT.TextBox.Text = numberToText(decTotal);
        }

        private float textToNumber(string text)
        {
            bool isSuccess = float.TryParse(text, out var value);
            return isSuccess ? value : 0;
        }

        private string numberToText(float number)
        {
            return number != 0 ? number.ToString("N0") : string.Empty;
        }
    }

    internal class DataItem
    {
        public string Name { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Holdings { get; set; }
        public string ConstructionCosts { get; set; }
    }
}
