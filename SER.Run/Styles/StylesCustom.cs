using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace SER.Run.Styles
{
   public partial class StylesCustom : ResourceDictionary
    {
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}