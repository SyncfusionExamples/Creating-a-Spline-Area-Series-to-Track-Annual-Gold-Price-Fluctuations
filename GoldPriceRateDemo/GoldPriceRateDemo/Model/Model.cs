

namespace GoldPriceRateDemo
{
    public class Model
    {
        public DateTime Year { get; set; }
        public double USD { get; set; }
        public double AUD { get; set; }
        public double CAD { get; set; }
        public double CHF { get; set; }
        public double CNY { get; set; }
        public double EUR { get; set; }
        public double GBP { get; set; }
        public double INR { get; set; }
        public double JPY { get; set; }

        public Model(DateTime year, double usd, double aud, double cad, double chf,double cny, double eur, double gbp, double inr, double jpy)
        {
            Year = year;
            USD = usd;
            AUD = aud;
            CAD = cad;
            CHF = chf;
            CNY = cny;
            EUR = eur;
            GBP = gbp;
            INR = inr;
            JPY = jpy;
        }
    }
}
