using System.Globalization;


namespace GoldPriceRateDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           series.TooltipTemplate = TooltipTemplate("USD"); ;
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(picker ==null || picker.SelectedItem == null)
                return;
            var selectedValue = picker.SelectedItem.ToString() ?? string.Empty;
            switch (selectedValue)
            {
                case "USD":
                    series.YBindingPath = "USD";
                    series.TooltipTemplate = TooltipTemplate("USD");
                    break;
                case "AUD":
                    series.YBindingPath = "AUD";
                    series.TooltipTemplate = TooltipTemplate("AUD");
                    break;
                case "CAD":
                    series.YBindingPath = "CAD";
                    series.TooltipTemplate = TooltipTemplate("AUD");
                    break;
                case "CHF":
                    series.YBindingPath = "CHF";
                    series.TooltipTemplate = TooltipTemplate("CHF");
                    break;
                case "CNY":
                    series.YBindingPath = "CNY";
                    series.TooltipTemplate = TooltipTemplate("CNY");
                    break;
                case "EUR":
                    series.YBindingPath = "EUR";
                    series.TooltipTemplate = TooltipTemplate("EUR");
                    break;
                case "GBP":
                    series.YBindingPath = "GBP";
                    series.TooltipTemplate = TooltipTemplate("GBP");
                    break;
                case "INR":
                    series.YBindingPath = "INR";
                    series.TooltipTemplate = TooltipTemplate("INR");
                    break;
                case "JPY":
                    series.YBindingPath = "JPY";
                    series.TooltipTemplate = TooltipTemplate("JPY");
                    break;
            }
        }

        private DataTemplate TooltipTemplate(string currency)
        {
            var tooltipTemplate = new DataTemplate(() =>
            {
                HorizontalStackLayout layout = new HorizontalStackLayout();

                Image trendIcon = new Image()
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HeightRequest = 25,
                    WidthRequest= 25, 
                };
                trendIcon.SetBinding(Image.SourceProperty, new Binding($"Item.{currency}", BindingMode.Default, converter: new TrendIconConverter()));

                Label text = new Label()
                { 
                    Text = "Annual Growth:",
                    TextColor = Colors.White,
                    FontSize = 12,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                };

                Label annualRate = new Label()
                {
                    TextColor = Colors.White,
                    FontSize = 12,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Margin = new Thickness(3,0,0,0)
                };
                annualRate.SetBinding(Label.TextProperty, new Binding($"Item.{currency}", BindingMode.Default, null, null, "{0}%"));

                layout.Children.Add(trendIcon);
                layout.Children.Add(text);
                layout.Children.Add(annualRate);
                return layout;
            });
            return tooltipTemplate;
        }

        
    }

    public class TrendIconConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
           if(value is double rate)
            {
                if (rate > 0)
                    return "uparrow.png";
                else
                    return "downarrow.png";
            }
            return string.Empty;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
