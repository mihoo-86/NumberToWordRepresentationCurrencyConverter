using CurrencyConverter.Const;
using CurrencyConverter.NumberToWordsConverters;
using CurrencyConverterCommon;
using System;

namespace CurrencyConverter
{
    public class CurrencyConverter
    {
        public string ConvertCurrencyToWords(decimal currency)
        {
            if (!CurrencyValidator.IsValid(currency))
            {
                throw new InvalidOperationException("Currency is out of range!");
            }

            int dollars = (int)Math.Floor(currency);

            int cents = (int)((currency - dollars) * 100);

            return $"{GetDollarPartString(dollars)}{GetCentsPartString(cents)}";
        }

        private static string GetDollarPartString(int dollars) 
        {
            string dollarWord = dollars == 1 ? CurrencyStrings.Dollar : CurrencyStrings.Dollars;

            string dollarsPartWord = NumberToWordsConverter.ConvertNumberToWords(dollars);

            dollarsPartWord += dollarsPartWord.EndsWith(" ") ? dollarWord : $" {dollarWord}";

            return dollarsPartWord;
        }

        private static string GetCentsPartString(int cents)
        {
            string centWord = cents == 1 ? CurrencyStrings.Cent : CurrencyStrings.Cents;

            return cents > 0 ? $" and {ShortNumberToWordsConverter.ConvertShortNumberToWords(cents)} {centWord}" : "";
        }
    }
}
