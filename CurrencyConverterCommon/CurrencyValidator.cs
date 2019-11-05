namespace CurrencyConverterCommon
{
    public static class CurrencyValidator
    {
        public static bool IsValid(decimal usdCurrency)
        {
            return usdCurrency >= 0 && usdCurrency <= 999999999.99m;
        }
    }
}
