namespace CurrencyConverterService
{
    public class CurrencyConverterService : ICurrencyConverterService
    {
        public string ConvertToWord(decimal usdCurrency)
        {
            CurrencyConverter.CurrencyConverter currencyConverter = new CurrencyConverter.CurrencyConverter();

            return currencyConverter.ConvertCurrencyToWords(usdCurrency);
        }
    }
}
