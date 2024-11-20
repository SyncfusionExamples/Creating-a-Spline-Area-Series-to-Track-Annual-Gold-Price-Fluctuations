using System.Globalization;
using Microsoft.Maui.Controls.Shapes;

namespace GoldPriceRateDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class CurrencyConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is Model model && parameter is Binding binding && binding.Source is Picker picker)
            {
                var selectedCurrency = picker.SelectedItem?.ToString()?.ToUpper();

                if (string.IsNullOrEmpty(selectedCurrency) || !model.CurrencyValues.TryGetValue(selectedCurrency, out double valueForCurrency))
                {
                    return string.Empty;
                }
               
                if (targetType == typeof(Brush))
                {
                    return valueForCurrency > 0 ? Color.FromArgb("#62825D") : Color.FromArgb("#b30000");
                }

                if (targetType == typeof(string))
                {
                    return valueForCurrency;
                }

                if (valueForCurrency > 0)
                {
                    return (new PathGeometryConverter().ConvertFromInvariantString("M15.995972,0L32,21.478999 0,21.478999z"));
                }
                else
                {
                    return (new PathGeometryConverter().ConvertFromInvariantString("M0,0L32,0 16,19.7z"));
                }
            }
           

            return string.Empty;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
