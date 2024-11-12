

namespace GoldPriceRateDemo
{
    public partial class MainPage : ContentPage
    {
        DataTemplate tooltipTemplate;
        public MainPage()
        {
            InitializeComponent();
            TooltipTemplate("USD");
            series.TooltipTemplate = tooltipTemplate;
        }

        private void SfComboBox_SelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
        {
            var selectedValue = comboBox.SelectedValue.ToString() ?? string.Empty;
            switch (selectedValue)
            {
                case "USD":
                    series.YBindingPath = "USD";
                    TooltipTemplate("USD");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "AUD":
                    series.YBindingPath = "AUD";
                    TooltipTemplate("AUD");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "CAD":
                    series.YBindingPath = "CAD";
                    TooltipTemplate("AUD");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "CHF":
                    series.YBindingPath = "CHF";
                    TooltipTemplate("CHF");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "CNY":
                    series.YBindingPath = "CNY";
                    TooltipTemplate("CNY");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "EUR":
                    series.YBindingPath = "EUR";
                    TooltipTemplate("EUR");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "GBP":
                    series.YBindingPath = "GBP";
                    TooltipTemplate("GBP");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "INR":
                    series.YBindingPath = "INR";
                    TooltipTemplate("INR");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
                case "JPY":
                    series.YBindingPath = "JPY";
                    TooltipTemplate("JPY");
                    series.TooltipTemplate = tooltipTemplate;
                    break;
            }
        }

        private void TooltipTemplate(string currency)
        {
            tooltipTemplate = new DataTemplate(() =>
            {
                HorizontalStackLayout layout = new HorizontalStackLayout();

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

                layout.Children.Add(text);
                layout.Children.Add(annualRate);
                return layout;
            });
        }
    }

}
