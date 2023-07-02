using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FN.Framtal.UserControls
{
    public class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            PreviewKeyDown += HandlePreviewKeyDown;
            PreviewTextInput += HandlePreviewTextInput;
            DataObject.AddPastingHandler(this, PastingHandler);
            TextAlignment = TextAlignment.Center;
            VerticalContentAlignment= VerticalAlignment.Center;
            BorderBrush = TryFindResource("MediumBrush") as Brush;
            BorderThickness = new Thickness(3);
        }

        private void HandlePreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.Key == Key.Space;
        }

        private void HandlePreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!IsTextAllowed(e.Text))
            {
                e.Handled = true;
                return;
            }

            var oldCaretIndex = CaretIndex;
            var oldText = Text;

            var newText = oldText.Insert(oldCaretIndex, e.Text);
            if (!IsValidNumber(newText))
            {
                e.Handled = true;
                return;
            }

            Text = toNumberText(newText);
            CaretIndex = oldCaretIndex + (Text.Length - oldText.Length);
            e.Handled = true;
        }

        private void PastingHandler(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var text = e.DataObject.GetData(typeof(string)) as string;

                if (!IsTextAllowed(text))
                    e.CancelCommand();
            }
            else
            {
                e.CancelCommand();
            }
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private static bool IsValidNumber(string text)
        {
            return text == "-" || float.TryParse(text, out _);
        }

        private static string toNumberText(string text)
        {
            return text == "-" ? text : float.Parse(text).ToString("N0");
        }
    }
}
