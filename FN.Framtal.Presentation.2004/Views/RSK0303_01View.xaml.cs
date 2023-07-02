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

namespace FN.Framtal.Presentation._2004.Views
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
            float hours = textToNumber(tbExtraWorkHours1.TextBox.Text);
            float rate = textToNumber(tbExtraWorkRate1.TextBox.Text);
            float total = hours * rate;
            tbExtraWorkTotal1.TextBox.Text = numberToText(total);
        }

        private void tbSetbExtraWorkTotal2_TextChanged(object sender, RoutedEventArgs e)
        {
            float hours = textToNumber(tbExtraWorkHours2.TextBox.Text);
            float rate = textToNumber(tbExtraWorkRate2.TextBox.Text);
            float total = hours * rate;
            tbExtraWorkTotal2.TextBox.Text = numberToText(total);
        }

        private void tbSetbOtherWorkTotal1_TextChanged(object sender, RoutedEventArgs e)
        {
            float hours = textToNumber(tbOtherWorkHours1.TextBox.Text);
            float rate = textToNumber(tbOtherWorkRate1.TextBox.Text);
            float total = hours * rate;
            tbOtherWorkTotal1.TextBox.Text = numberToText(total);
        }

        private void tbSetbOtherWorkTotal2_TextChanged(object sender, RoutedEventArgs e)
        {
            float hours = textToNumber(tbOtherWorkHours2.TextBox.Text);
            float rate = textToNumber(tbOtherWorkRate2.TextBox.Text);
            float total = hours * rate;
            tbOtherWorkTotal2.TextBox.Text = numberToText(total);
        }
        private void tbSetAtoETotal_TextChanged(object sender, RoutedEventArgs e)
        {
            float decATotal1 = textToNumber(tbATotal1.TextBox.Text);
            float decATotal2 = textToNumber(tbATotal2.TextBox.Text);
            float decATotal3 = textToNumber(tbATotal3.TextBox.Text);
            float decATotal4 = textToNumber(tbATotal4.TextBox.Text);
            float decATotal5 = textToNumber(tbATotal5.TextBox.Text);
            float decATotal6 = textToNumber(tbATotal6.TextBox.Text);
            float decATotal7 = textToNumber(tbATotal7.TextBox.Text);
            float decATotal = decATotal1 + decATotal2 + decATotal3 + decATotal4 + decATotal5 + decATotal6 + decATotal7;

            float decBTotal = textToNumber(tbBTotal.TextBox.Text);

            float decCTotal1 = textToNumber(tbCTotal1.TextBox.Text);
            float decCTotal2 = textToNumber(tbCTotal2.TextBox.Text);
            float decCTotal = decCTotal1 + decCTotal2;

            float decDTotal1 = textToNumber(tbExtraWorkTotal1.TextBox.Text);
            float decDTotal2 = textToNumber(tbExtraWorkTotal2.TextBox.Text);
            float decDTotal = decDTotal1 + decDTotal2;

            float decETotal1 = textToNumber(tbOtherWorkTotal1.TextBox.Text);
            float decETotal2 = textToNumber(tbOtherWorkTotal2.TextBox.Text);
            float decETotal = decETotal1 + decETotal2;

            float decAtoETotal = decATotal + decBTotal + decCTotal + decDTotal + decETotal;
            tbAtoETotal.TextBox.Text = numberToText(decAtoETotal);
        }

        private void tbSetJTotal_TextChanged(object sender, RoutedEventArgs e)
        {
            float decFTotal = textToNumber(tbFTotal.TextBox.Text);

            float decGTotal = textToNumber(tbGTotal.TextBox.Text);

            float decHTotal = textToNumber(tbHTotal.TextBox.Text);

            float decITotal = textToNumber(tbITotal.TextBox.Text);

            float decJTotal = decFTotal + decGTotal + decHTotal - decITotal;
            tbJTotal.TextBox.Text = numberToText(decJTotal);
        }

        private void tbSetJtoLTotal_TextChanged(object sender, RoutedEventArgs e)
        {
            float decJTotal = textToNumber(tbJTotal.TextBox.Text);

            float decKTotal = textToNumber(tbKTotal.TextBox.Text);

            float decLTotal = textToNumber(tbLTotal.TextBox.Text);

            float decJtoLTotal = decJTotal + decKTotal - decLTotal;
            tbJtoLTotal.TextBox.Text = numberToText(decJtoLTotal);
        }

        private void tbSetTotalInItem4_1_TextChanged(object sender, RoutedEventArgs e)
        {
            float decRealEstateAppraisal = textToNumber(tbRealEstateAppraisal.TextBox.Text);

            float decUnestimatedConstructionCosts = textToNumber(tbUnestimatedConstructionCosts.TextBox.Text);

            float decTotalInItem4_1 = decRealEstateAppraisal + decUnestimatedConstructionCosts;
            tbTotalInItem4_1.TextBox.Text = numberToText(decTotalInItem4_1);
        }

        private void dgData_tbConstructionCosts_TextChanged(object sender, RoutedEventArgs e)
        {
            float decTotal = 0;
            foreach (DataItem item in dgData.Items)
            { decTotal += textToNumber(item.ConstructionCosts); }
            tbConstructionCostsTotal.TextBox.Text = numberToText(decTotal);
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
