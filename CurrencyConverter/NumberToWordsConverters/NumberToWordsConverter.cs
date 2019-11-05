using CurrencyConverter.Const;
using System;
using System.Linq;

namespace CurrencyConverter.NumberToWordsConverters
{
    internal class NumberToWordsConverter
    {
        public static string ConvertNumberToWords(int number)
        {
            if (number == 0)
            {
                return Numbers.Zero;
            }

            string words = "";

            if (number >= (int)Math.Pow(10, 2))
            {
                var powers = Numbers.BigPowerOfTenNumbers.Keys.OrderByDescending(x => x);

                foreach (int power in powers)
                {
                    int powerOfTenNumber = (int)Math.Pow(10, power);

                    int numberDividedByPowerOfTen = number / powerOfTenNumber;

                    if (numberDividedByPowerOfTen > 0)
                    {
                        words += $"{ConvertNumberToWords(numberDividedByPowerOfTen)} {Numbers.BigPowerOfTenNumbers[power]} ";
                        number %= powerOfTenNumber;
                    }
                }
            }

            words = FixWhiteSpaces(words);

            words += ShortNumberToWordsConverter.ConvertShortNumberToWords(number);

            return words;
        }

        private static string FixWhiteSpaces(string words)
        {
            if (words != "" && !words.EndsWith(" "))
            {
                words += " ";
            }

            return words;
        }
    }
}
