using System.Collections.ObjectModel;
using System.Reflection;


namespace GoldPriceRateDemo
{
    public class ViewModel
    {
        public ObservableCollection<Model> GoldPriceRate { get; set; }
        public string[] CurrencyName { get; set; }
        public string SelectedCurrency { get; set; }
        private DateTime year;

        public ViewModel()
        {
            GoldPriceRate = new ObservableCollection<Model>();
            CurrencyName = new string[] { "USD", "AUD", "CAD", "CHF", "CNY", "EUR", "GBP", "INR", "JPY" };
            SelectedCurrency = "USD";
            ReadCSV();
        }

        private void ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream? inputStream = executingAssembly.GetManifestResourceStream("GoldPriceRateDemo.Resources.Data.AnnualGoldExchangeData.csv");

            string? line;
            List<string> lines = new List<string>();

            if (inputStream != null)
            {
                using StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAt(0);

                foreach (var dataPoint in lines)
                {
                    string[] data = dataPoint.Split(',');
                    if (int.TryParse(data[0], out int yearValue))
                        year = new DateTime(yearValue, 1, 1);
                    double usd = Convert.ToDouble(data[1]);
                    double aud = Convert.ToDouble(data[2]);
                    double cad = Convert.ToDouble(data[3]);
                    double chf = Convert.ToDouble(data[4]);
                    double cny = Convert.ToDouble(data[5]);
                    double eur = Convert.ToDouble(data[6]);
                    double gbp = Convert.ToDouble(data[7]);
                    double inr = Convert.ToDouble(data[8]);
                    double jpy = Convert.ToDouble(data[9]);

                    GoldPriceRate.Add(new Model(year, usd, aud, cad, chf, cny, eur, gbp, inr, jpy));
                }
            }

        }
    }
}
