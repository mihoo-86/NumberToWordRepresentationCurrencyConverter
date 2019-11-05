using CurrencyConverter.Const;

namespace CurrencyConverter.NumberToWordsConverters
{
    internal class ShortNumberToWordsConverter
    {
        public static string ConvertShortNumberToWords(int number)
        {
            string words = "";

            if (number < 20)
            {
                words += ConvertSingleDigitNumberToWord(number);
            }
            else
            {
                words += ConvertDoubleDigitNumberToWord(number);
            }

            return words;
        }

        private static string ConvertSingleDigitNumberToWord(int number)
        {
            if (number == 0)
            {
                return "";
            }

            return Numbers.Units[number];
        }

        private static string ConvertDoubleDigitNumberToWord(int number)
        {
            string words = Numbers.Tens[number / 10];

            if ((number % 10) > 0)
            {
                words += "-" + ConvertSingleDigitNumberToWord(number % 10);
            }

            return words;
        }
    }
}
